from Elements.G.Transformers.Base.ITransformer import ITransformer
from Elements.G.Factories.ElementsPopulatorFactory import ElementsPopulatorFactory

class ForEachModuleSectionTransformerWithComma(ITransformer):
	def __init__(self, sectionName, templates, modules):
		super(ForEachModuleSectionTransformerWithComma, self).__init__(sectionName, templates, modules)

		self.partsFromSectionName = self.name.split('_')
		self.populatorName = self.partsFromSectionName[1]

	def getType(self):
		return "ForEachModuleTransformerWithComma"

	def build(self, moduleName):		
		moduleSettings = self.parameters[moduleName]
		self.populator = ElementsPopulatorFactory().create(
														self.populatorName,
														self.name,
														self.templates,
														moduleSettings)
		return self.populator.populate()

	def getName(self):
		return self.partsFromSectionName[-1]

	def getSectionName(self):
		return "#%s" % (self.name)
	
	def getBuiltContent(self, blocks):
		return ',\n'.join(blocks)

	def replaceAndReturnContent(self, content, blocks):		
		return content.replace(self.getSectionName(), self.getBuiltContent(blocks))

	def transformSection(self, inputContent):
		blocks = []

		for moduleName, moduleParameter in self.parameters.iteritems():
			built = self.build(moduleName)
			
			if built != "":
				blocks.append(built)
		
		return self.replaceAndReturnContent(inputContent, blocks)