class IFileBuilder(object):
	def __init__(self, writer, modules, templates, baseContent, console):
		self.writer = writer
		self.modules = modules
		self.templatesRepository = templates
		self.content = baseContent
		self.console = console

	def generate(self):
		raise NotImplementedError("IFileBuilder is an abstract class.")