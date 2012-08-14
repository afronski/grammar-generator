from Base.IFilesRepository import IFilesRepository

class InputRepository(IFilesRepository):
	def __init__(self):
		self.InputDirectory = "Modules"		
		self.Pattern = "*.input"
		super(InputRepository, self).__init__(self.InputDirectory)
	
	def getPattern(self):
		return self.Pattern