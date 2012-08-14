from Base.IFilesRepository import IFilesRepository

class PartsRepository(IFilesRepository):
	def __init__(self):
		self.PartsDirectory = "Templates/Parts"
		self.Pattern = "*.template"
		super(PartsRepository, self).__init__(self.PartsDirectory)

	def getPattern(self):
		return self.Pattern