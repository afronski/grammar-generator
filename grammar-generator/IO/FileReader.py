class FileReader:
	def getContent(self, fileName):
		inputStream = open(fileName, 'r')
		content = inputStream.read()
		inputStream.close()
		
		return content