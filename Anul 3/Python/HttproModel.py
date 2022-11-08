class HttproModel:
   value = None
   message = ""
   status = ""
 
   initialValue = None
   initialMessage = ""
 
   def __init__ (self, initialValue = None, initialMessage = ""):
       self.initialValue = initialValue
       self.initialMessage = initialMessage
       self.Reset()
  
   def Reset(self):
       self.message = self.initialMessage
       self.status = "waiting"
       self.ResetValue()
 
   def ResetValue(self):
       self.value = self.initialValue
  
   def toString(self):
       return {
           "message": self.message,
           "value": self.value,
           "status": self.status
       }
