from Elements.STG.Base.IElementForStg import IElementForStg

class DateElementForStg(IElementForStg):
	def __init__(self, templates, settingsObject):
		self.typeName = "Date"
		self.templateName = "DateTypeFilteringColumn"

		super(DateElementForStg, self).__init__(templates, settingsObject)

	def getType(self):
		return self.typeName

	def getTemplateName(self):
		return self.templateName		