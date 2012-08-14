from IO.DirectorySniffer import DirectorySniffer

class IFilesRepository(object):
	def __init__(self, directory):
		self.directory = directory
		self.sniffer = DirectorySniffer(directory)

	def loadAll(self):
		return self.sniffer.sniff(self.getPattern())
	
	def getPattern(self):
		raise NotImplementedError("IFilesRepository is an abstract class.")