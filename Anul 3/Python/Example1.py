from HttproModel import HttproModel
from Httpro import Httpro
httpro = Httpro()

model = HttproModel()

httpro.delete('https://postman-echo.com/delete').query({"id":"123"}).exec(model)

print(model.value)






#httpro.get("https://postman-echo.com/get").query({"key":"val", "a":53}).exec(model)

#print(model.toString())

#if model.status == 'success':
#    print(model.value)
#else:
#    print(model.message)