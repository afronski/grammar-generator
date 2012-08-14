from Builders.Base.ITemplateFileBuilder import ITemplateFileBuilder
from Elements.STG.Factories.StgFilteringElementsFactory import StgFilteringElementsFactory
from Elements.STG.Factories.StgVisibleElementsFactory import StgVisibleElementsFactory
from Elements.STG.Factories.StgSortingElementsFactory import StgSortingElementsFactory

class StringTemplateGroupFileBuilder(ITemplateFileBuilder):
	def __init__(self, writer, modules, templates, base, console):
		super(StringTemplateGroupFileBuilder, self).__init__(writer, modules, templates, base, console)
		self.clear()

	def validateListName(self, listName):
		return listName.find("Parameters") != -1

	def extendWithPrefix(self, parameter, module, name):
		attributeName = "ModulePrefix"

		if not attributeName in module:
			raise EnvironmentError("Missing '%s' attribute for '%s' module." % (attributeName, name))

		parameter[attributeName] = module[attributeName]
		return parameter

	def pushValidElement(self, element, listForAdding):
		if element != None:
			listForAdding.append(element)

	def clear(self):
		self.factoriesAndResults = {
			"Filtering" : ([], StgFilteringElementsFactory()),
			"Visible"   : ([], StgVisibleElementsFactory()),
			"Sorting"   : ([], StgSortingElementsFactory())
		}

	def joinListByNewLines(self, list, length = 1):
		return ('\n' * length).join(list)
		
	def algorithmStep(self, name, module):
		self.console.increaseIndent()
		self.console.increaseIndent()

		self.console.writeWithIndent("Module '%s'" % (name))

		for parametersListName, parametersList in module.iteritems():
			if self.validateListName(parametersListName):
				self.console.increaseIndent()
				self.console.writeWithIndent("Parameter list '%s'" % (parametersListName))				

				for parameterName, parameter in parametersList.iteritems():
					self.console.increaseIndent()
					self.console.writeWithIndent("Parameter '%s'" % (parameterName))
					
					parameter = self.extendWithPrefix(parameter, module, name)

					# Creating element based on list name in which is it.
					for name, (results, factory) in self.factoriesAndResults.iteritems():
						self.pushValidElement(
							factory.create(parametersListName, self.templatesRepository, parameter),
							results)

					self.console.decreaseIndent()
				self.console.decreaseIndent()

		self.console.decreaseIndent()
		self.console.decreaseIndent()
				
		self.writer.pushData(
			self.joinListByNewLines([
				self.joinListByNewLines([ 
					result.resolve() for result in results 
				]) 
				for name, (results, factory) in self.factoriesAndResults.iteritems()
			], 2))