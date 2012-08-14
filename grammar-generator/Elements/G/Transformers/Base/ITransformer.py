class ITransformer(object):
	def __init__(self, sectionName, templates, modules):
		self.name = sectionName
		self.templates = templates
		self.parameters = modules

	def getType(self):
		raise NotImplementedError("ITransformer is an abstract class.")

	def getName(self):
		raise NotImplementedError("ITransformer is an abstract class.")

	def build(self, moduleName):
		raise NotImplementedError("ITransformer is an abstract class.")

	def transformSection(self, inputContent):
		raise NotImplementedError("ITransformer is an abstract class.")