from Builders.Base.IFileBuilder import IFileBuilder

class ITemplateFileBuilder(IFileBuilder):
	def __init__(self, writer, modules, templates, baseContent, console):
		super(ITemplateFileBuilder, self).__init__(writer, modules, templates, baseContent, console)

		self.newParagraph = "\n\n"
		self.writer.pushData(self.content)

	def prepareWriter(self):
		self.writer.pushData(self.newParagraph)

	def generate(self):
		for name, module in self.modules.iteritems():
			self.clear()
			self.prepareWriter()
			self.algorithmStep(name, module)
			
	def algorithmStep(self, name, module):
		raise NotImplementedError("ITemplateFileBuilder is an abstract class.")

	def clear(self):
		raise NotImplementedError("ITemplateFileBuilder is an abstract class.")