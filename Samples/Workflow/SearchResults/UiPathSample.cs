using UiPath;

namespace SearchResults 
{
	class UiPathSample
	{
		UiNode uiNode = null;
		UiImage uiImage = null;
		UiSystem uiSystem = null;
		
		private void InitUiPathObjects()
		{
			uiNode = UiFactory.Instance.NewUiNode();
			uiImage = UiFactory.Instance.NewUiImage();
			uiSystem = UiFactory.Instance.NewUiSystem();
		}

        public UiPathSample()
        {
            InitUiPathObjects();

            //start using the UiPath API
            //if you need help read the documentation here http://www.uipath.com
            //or use UiStudio.exe visual tool to generate code and speed up development

        }
	}
}