import re
from Elements.G.Factories.SectionTransformerFactory import SectionTransformerFactory

from Builders.Base.IFileBuilder import IFileBuilder

class GrammarFileBuilder(IFileBuilder):
	def __init__(self, writer, modules, templates, baseContent, console):
		super(GrammarFileBuilder, self).__init__(writer, modules, templates, baseContent, console)

		self.sectionRegEx = "\#([_\-a-zA-z0-9\$]+)"

	def findAllSections(self, value):
		return re.finditer(self.sectionRegEx, value);

	def generate(self):
		self.console.increaseIndent()
		self.console.increaseIndent()
	
		factory = SectionTransformerFactory()
		for sectionName in self.findAllSections(self.content):
			validSectionName = sectionName.group(1)		
			elementName = validSectionName.split('_')[-1]
							
			self.console.writeWithIndent("Section '%s'" % (elementName))

			transformer = factory.create(validSectionName, self.templatesRepository, self.modules)
			self.content = transformer.transformSection(self.content)

		self.persistAllChanges(self.content)

		self.console.decreaseIndent()
		self.console.decreaseIndent()			

	def persistAllChanges(self, content):
		self.writer.pushData(content)