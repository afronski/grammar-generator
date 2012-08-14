from Elements.STG.Base.IElementForStg import IElementForStg

class StandardElementForStg(IElementForStg):
	def __init__(self, templates, settingsObject):
		self.typeName = "Standard"
		self.templateName = "FilteringColumn"

		super(StandardElementForStg, self).__init__(templates, settingsObject)

	def getType(self):
		return self.typeName

	def getTemplateName(self):
		return self.templateName		