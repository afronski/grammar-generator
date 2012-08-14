from Elements.STG.Base.IElementForStg import IElementForStg

class SortingElementForStg(IElementForStg):
	def __init__(self, templates, settingsObject):
		self.typeName = "Standard"
		self.templateName = "SortingColumn"

		super(SortingElementForStg, self).__init__(templates, settingsObject)

	def getType(self):
		return self.typeName

	def getTemplateName(self):
		return self.templateName