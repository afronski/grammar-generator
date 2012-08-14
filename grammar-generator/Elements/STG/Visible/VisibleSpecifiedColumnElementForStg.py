from Elements.STG.Base.IElementForStg import IElementForStg

class VisibleSpecifiedColumnElementForStg(IElementForStg):
	def __init__(self, templates, settingsObject):
		self.typeName = "Specified"
		self.templateName = "SpecifiedVisibledColumn"

		super(VisibleSpecifiedColumnElementForStg, self).__init__(templates, settingsObject)

	def getType(self):
		return self.typeName

	def getTemplateName(self):
		return self.templateName