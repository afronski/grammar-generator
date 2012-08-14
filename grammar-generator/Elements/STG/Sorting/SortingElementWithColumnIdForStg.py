from Elements.STG.Base.IElementForStg import IElementForStg

class SortingElementWithColumnIdForStg(IElementForStg):
	def __init__(self, templates, settingsObject):
		self.typeName = "WithColumnID"
		self.templateName = "SortingColumnWithID"

		super(SortingElementWithColumnIdForStg, self).__init__(templates, settingsObject)

	def getType(self):
		return self.typeName

	def getTemplateName(self):
		return self.templateName