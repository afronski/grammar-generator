from Elements.STG.Factories.Base.IStgClausesElementsFactory import IStgClausesElementsFactory
from Elements.STG.Sorting.SortingSpecifiedColumnElementForStg import SortingSpecifiedColumnElementForStg
from Elements.STG.Sorting.SortingElementWithColumnIdForStg import SortingElementWithColumnIdForStg
from Elements.STG.Sorting.SortingElementForStg import SortingElementForStg

class StgSortingElementsFactory(IStgClausesElementsFactory):
	def getAttributeNameForSpecifiedElement(self):
		return "SortingColumnName"

	def createSpecifiedColumnElement(self, templates, settingsObject):
		return SortingSpecifiedColumnElementForStg(templates, settingsObject)

	def createElementWithColumnID(self, templates, settingsObject):
		return SortingElementWithColumnIdForStg(templates, settingsObject)

	def createElement(self, templates, settingsObject):
		return SortingElementForStg(templates, settingsObject)