from Elements.G.Populators.Base.IElementPopulator import IElementPopulator

class AllParametersListWithOneNamePopulator(IElementPopulator):
	def __init__(self, sectionName, templates, settingsObject):
		super(AllParametersListWithOneNamePopulator, self).__init__(sectionName, templates, settingsObject)
		self.separator = "\n|\n"
		self.mainName = self.templateName.split('-')[1]

	def getType(self):
		return "CreateAllParametersListWithOneName"

	def openClause(self, name):
		return self.parameters["ModulePrefix"] + "_" + name.lower() + ":\n"

	def closeClause(self):
		return "\n;\n"

	def populate(self):
		constructedParameters = []
		result = self.openClause(self.mainName)

		for parameterListName, parameterList in self.parameters.iteritems():
			if parameterListName.find("Parameters")	!= -1:
				filledTemplatesList = []

				for parameterName, parameters in parameterList.iteritems():
					self.handleNotImplementedTemplates([ self.passedNotImplementedTemplateName ], parameters)
					filledTemplatesList.append(self.templateResolver.fill(self.expandParameters(parameters)))
					self.restoreDefault()

				if len(filledTemplatesList) > 0:
					constructedParameters.append(self.separator.join(filledTemplatesList))

		result += self.separator.join(constructedParameters)
		result += self.closeClause()
		
		return result
