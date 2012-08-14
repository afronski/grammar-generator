from Base.IFilesRepository import IFilesRepository

class BaseRepository(IFilesRepository):
	def __init__(self):
		self.BaseDirectory = "Templates/Base"
		self.Pattern = "*.template"
		super(BaseRepository, self).__init__(self.BaseDirectory)

	def getPattern(self):
		return self.Pattern