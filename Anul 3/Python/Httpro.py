import urllib.request
import json

class RequestHolder:
     headers = {}
     searchParams = {}
     body = {}
     method = "" # 'get','post', 'put' or 'delete'
     url = ""
     def __init__(self, method, url):
          self.method = method
          self.url = url

     
            
class Httpro():
     
     __instance = None
     def __call__(self):
          if self.__instance is None:
               self.__instance = self.__call__()
          return self.__instance

     request = None
                 
     def get(self, url): return self.CreateRequest("GET",url)
     def post(self, url): return self.CreateRequest("POST",url)
     def put(self, url): return self.CreateRequest("PUT",url)
     def delete(self, url): return self.CreateRequest("DELETE",url)

     def headers(self, headers):
          self.request.headers.update(headers)
          return self

     def query(self, query):
          self.request.searchParams.update(query)
          return self

     def body(self, body):
          self.request.body.update(body)
          return self

     def CreateRequest(self, method,url):
          self.request = RequestHolder(method,url)
          return self
          
     def exec(self, model=None):
          try:

               if model != None:
                    model.status = 'loading'

               result = self.execRequest()

               if result['status'] == "ok":
                    if model != None:
                         model.status = 'success'
                         model.value = result['value']
                    else:
                         return result['value']
               else:
                    if model != None:
                         model.status = 'error'
                         model.message = result['message']
                    else:
                         return result['message']

               
          except Exception as e:
               print(e)
               return e

     def execRequest(self):
          try:
               searchParams = urllib.parse.urlencode(self.request.searchParams)
               url = self.request.url

               if len(searchParams) > 0:
                    url = url + '?' + searchParams
               
               pyReq = urllib.request.Request(url,headers=self.request.headers, method=self.request.method)
               if self.request.method != "GET":
                    pyReq.data = str(self.request.body).encode('utf-8')

               req = urllib.request.urlopen(pyReq)
               res = req.read()
               return {'status': "ok", 'value': json.loads(res.decode('utf-8'))}

          except Exception as e:
               print(e)
               return { 'status': "error", 'message': e}
 
            
