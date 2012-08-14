from Content.TemplateResolver import TemplateResolver

class IElementForStg(object):
	def __init__(self, templates, settingsObject):
		self.templatesRepository = templates
		self.settingsObject = settingsObject
		self.templateResolver = TemplateResolver(self.templatesRepository, self.getTemplateName())

	def getType(self):
		raise NotImplementedError("IElementForStg is an abstract class.")

	def getTemplateName(self):
		raise NotImplementedError("IElementForStg is an abstract class.")

	def resolve(self):
		return self.templateResolver.fill(self.settingsObject)