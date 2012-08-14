from Elements.STG.Factories.Base.IStgClausesElementsFactory import IStgClausesElementsFactory
from Elements.STG.Visible.VisibleSpecifiedColumnElementForStg import VisibleSpecifiedColumnElementForStg
from Elements.STG.Visible.VisibleElementWithColumnIdForStg import VisibleElementWithColumnIdForStg
from Elements.STG.Visible.VisibleElementForStg import VisibleElementForStg

class StgVisibleElementsFactory(IStgClausesElementsFactory):
	def getAttributeNameForSpecifiedElement(self):
		return "VisibleColumnName"

	def createSpecifiedColumnElement(self, templates, settingsObject):
		return VisibleSpecifiedColumnElementForStg(templates, settingsObject)

	def createElementWithColumnID(self, templates, settingsObject):
		return VisibleElementWithColumnIdForStg(templates, settingsObject)

	def createElement(self, templates, settingsObject):
		return VisibleElementForStg(templates, settingsObject)