from Elements.STG.Base.IElementForStg import IElementForStg

class VisibleElementWithColumnIdForStg(IElementForStg):
	def __init__(self, templates, settingsObject):
		self.typeName = "WithColumnID"
		self.templateName = "VisibledColumnWithID"

		super(VisibleElementWithColumnIdForStg, self).__init__(templates, settingsObject)

	def getType(self):
		return self.typeName

	def getTemplateName(self):
		return self.templateName			