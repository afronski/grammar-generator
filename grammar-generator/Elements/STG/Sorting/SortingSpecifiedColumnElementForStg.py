from Elements.STG.Base.IElementForStg import IElementForStg

class SortingSpecifiedColumnElementForStg(IElementForStg):
	def __init__(self, templates, settingsObject):
		self.typeName = "Specified"
		self.templateName = "SpecifiedSortingColumn"

		super(SortingSpecifiedColumnElementForStg, self).__init__(templates, settingsObject)

	def getType(self):
		return self.typeName

	def getTemplateName(self):
		return self.templateName	