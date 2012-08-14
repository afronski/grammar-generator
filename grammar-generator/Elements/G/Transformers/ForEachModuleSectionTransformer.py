from Elements.G.Transformers.Base.ITransformer import ITransformer
from Elements.G.Factories.ElementsPopulatorFactory import ElementsPopulatorFactory

class ForEachModuleSectionTransformer(ITransformer):
	def __init__(self, sectionName, templates, modules):
		super(ForEachModuleSectionTransformer, self).__init__(sectionName, templates, modules)

		self.partsFromSectionName = self.name.split('_')
		self.populatorName = self.partsFromSectionName[1]

	def getType(self):
		return "ForEachModuleTransformer"

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
		return '\n'.join(blocks)

	def replaceAndReturnContent(self, content, blocks):		
		return content.replace(self.getSectionName(), self.getBuiltContent(blocks))

	def transformSection(self, inputContent):
		blocks = []

		for moduleName, moduleParameter in self.parameters.iteritems():
			blocks.append(self.build(moduleName))
		
		return self.replaceAndReturnContent(inputContent, blocks)