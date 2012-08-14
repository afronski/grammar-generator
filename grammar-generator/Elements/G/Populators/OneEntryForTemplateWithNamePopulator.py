from Elements.G.Populators.Base.IElementPopulator import IElementPopulator

class OneEntryForTemplateWithNamePopulator(IElementPopulator):
	def __init__(self, sectionName, templates, settingsObject):
		super(OneEntryForTemplateWithNamePopulator, self).__init__(sectionName, templates, settingsObject)
		self.mainName = self.templateName.split('-')[1]

	def getType(self):
		return "CreateOneEntryForTemplateWithName"

	def openClause(self, name):
		return self.parameters["ModulePrefix"] + "_" + name.lower() + ":\n"

	def closeClause(self):
		return "\n;\n"

	def createParameters(self):
		parameter = {}
		parametersForExpansion = [ "ModuleShortName", "ModuleLongName", "ModulePrefix" ]

		for parameterName in parametersForExpansion:
			parameter[parameterName] = self.parameters[parameterName]

		parameter["PostFix"] = self.settingName.lower()

		return parameter

	def populate(self):
		result = self.openClause(self.mainName)
		result += self.templateResolver.fill(self.createParameters())
		result += self.closeClause()

		return result