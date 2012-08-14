from Elements.G.Populators.Base.IElementPopulator import IElementPopulator

class AllParametersListPopulator(IElementPopulator):
	def __init__(self, sectionName, templates, settingsObject):
		super(AllParametersListPopulator, self).__init__(sectionName, templates, settingsObject)
		self.separator = "\n|\n"

	def getType(self):
		return "CreateParametersListWithName"

	def openClause(self, name):
		return self.parameters["ModulePrefix"] + "_" + name.lower() + ":\n"

	def closeClause(self):
		return "\n;\n"

	def populate(self):
		result = ""

		for parameterListName, parameterList in self.parameters.iteritems():
			if parameterListName.find("Parameters")	!= -1:
				result += self.openClause(parameterListName)	

				filledTemplatesList = []

				for parameterName, parameters in parameterList.iteritems():
					self.handleNotImplementedTemplates([ "NotImplemented" ], parameters)
					filledTemplatesList.append(self.templateResolver.fill(self.expandParameters(parameters)))
					self.restoreDefault()

				result += self.separator.join(filledTemplatesList)
				result += self.closeClause()

		return result
