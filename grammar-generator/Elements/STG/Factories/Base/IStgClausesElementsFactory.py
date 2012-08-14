class IStgClausesElementsFactory(object):
	def create(self, name, templates, settingsObject):
		hasSpecifiedColumn = self.getAttributeNameForSpecifiedElement() in settingsObject
		hasColumnID = "ColumnNameForID" in settingsObject

		if hasSpecifiedColumn:
			return self.createSpecifiedColumnElement(templates, settingsObject)
		elif hasColumnID:
			return self.createElementWithColumnID(templates, settingsObject)

		return self.createElement(templates, settingsObject)

	def getAttributeNameForSpecifiedElement(self):
		raise NotImplementedError("IStgClausesElementsFactory is an abstract class.")

	def createSpecifiedColumnElement(self, templates, settingsObject):
		raise NotImplementedError("IStgClausesElementsFactory is an abstract class.")

	def createElementWithColumnID(self, templates, settingsObject):
		raise NotImplementedError("IStgClausesElementsFactory is an abstract class.")

	def createElement(self, templates, settingsObject):
		raise NotImplementedError("IStgClausesElementsFactory is an abstract class.")		