import string

class TemplateResolver:
	def __init__(self, templateRepository, templateName):
		self.templateName = templateName
		self.templateRepository = templateRepository
	
	def fill(self, dictionaryData):		
		return string.Template(self.templateRepository[self.templateName]).safe_substitute(dictionaryData)