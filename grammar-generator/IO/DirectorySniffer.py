import os
import fnmatch

class DirectorySniffer:
	def __init__(self, directoryPath):
		self.path = directoryPath

	def sniff(self, pattern):		
		matches = []

		# Walk recursively inside specified path 
		# and match filenames against specified pattern 
		# also inside subdirectories.
		for root, dirnames, filenames in os.walk(self.path):
			for filename in fnmatch.filter(filenames, pattern):
				matches.append(os.path.join(root, filename))

		return matches

	def bareSniff(self, pattern):
		files = self.sniff(pattern)
		return [ os.path.basename(filePath) for filePath in files ]

	def sniffOnlyNames(self, pattern):
		files = self.bareSniff(pattern)
		return [ os.path.splitext(filePath)[0] for filePath in files ]