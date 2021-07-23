import requests
from bs4 import BeautifulSoup

LIMIT = 50
URL = "https://www.indeed.com/jobs?q=python&limit="+str(LIMIT)


def get_last_pages():
    result = requests.get(URL)

    soup = BeautifulSoup(result.text, "html.parser")

    pagination = soup.find("div", {"class": "pagination"})

    links = pagination.find_all('a')
    pages = []
    for link in links[:-1]:
        pages.append(int(link.string))
    max_page = pages[-1]
    return max_page


def extract_job(html):
    title = html.find("h2", {"class": "title"}).find("a")["title"]
    company = html.find("span", {"class": "company"})    
    company_anchor = company.find("a")
    if company.find("a") is not None:
        company = str(company_anchor.string)
    else:
        company = str(company.string)   
    company = company.strip()
    location = html.find("div", {"class": "recJobLoc"})["data-rc-loc"]
    job_id = html["data-jk"]
    return {
        'title': title,
        'company': company,
        'location': location,
        'link': "https://www.indeed.com/viewjob?jk="+str(job_id)
    }


def get_jobs(last_page):  
    jobs = []
    for page in range(last_page):
        print("Scrapping page "+str(page))
        result = requests.get(str(URL)+"&start="+str(page*LIMIT))
        soup = BeautifulSoup(result.text, "html.parser")
        results = soup.find_all("div", {"class": "jobsearch-SerpJobCard"})
        for result in results:
            jobs.append(extract_job(result))
    return jobs

def get_job():
    last_page = get_last_pages()
    jobs = get_jobs(last_page)
    return jobs