using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using Sigsence.ApplicationElements;
using Sigsence.ProgrammingInterface.Extend;

namespace Sigsence.ProgrammingInterface
{
    /// <summary>
    /// 
    /// </summary>
    public delegate void CallInitFormEventHandler();
    /// <summary>
    /// 
    /// </summary>
    public delegate void ImplementUserControlEventHandler();
    /// <summary>
    /// 
    /// </summary>
    public delegate void AssignCustomPropertiesPanelEventHandler();
    /// <summary>
    /// 
    /// </summary>
    /// <param name="fieldName"></param>
    public delegate void UpdateFromGridCategoryEventHandler(string fieldName);
    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public delegate void ObjectDoubleClickEventHandler(object sender, EventArgs e);
    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public delegate void ObjectClickEventHandler(object sender, EventArgs e);
    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public delegate void ObjectMouseDownEventHandler(object sender, EventArgs e);
    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public delegate void ObjectMouseUpEventHandler(object sender, EventArgs e);
    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public delegate void ObjectMouseMoveEventHandler(object sender, EventArgs e);
    /// <summary>
    /// 
    /// </summary>
    public delegate void ProcessSequenceSourceEventHandler();
    /// <summary>
    /// 
    /// </summary>
    public delegate void SequenceDataUpateEventHandler(object sender, ObjDataUpdateEventArgsInf e);
    /// <summary>
    /// 
    /// </summary>
    public interface ISigsenceInterface
    {
        /// <summary>
        /// 
        /// </summary>
        event CallInitFormEventHandler CallInitFormEventInf;
        /// <summary>
        /// 
        /// </summary>
        event ImplementUserControlEventHandler ImplementUserControlEventInf;
        /// <summary>
        /// 
        /// </summary>
        event AssignCustomPropertiesPanelEventHandler AssignCustomPropertiesPanelEventInf;
        /// <summary>
        /// 
        /// </summary>
        event UpdateFromGridCategoryEventHandler UpdateFromGridCategoryEventInf;
        /// <summary>
        /// 
        /// </summary>
        event ObjectDoubleClickEventHandler ObjectDoubleClickEventInf;
        /// <summary>
        /// 
        /// </summary>
        event ObjectClickEventHandler ObjectClickEventInf;
        /// <summary>
        /// 
        /// </summary>
        event ObjectMouseDownEventHandler ObjectMouseDownEventInf;
        /// <summary>
        /// 
        /// </summary>
        event ObjectMouseUpEventHandler ObjectMouseUpEventInf;
        /// <summary>
        /// 
        /// </summary>
        event ObjectMouseMoveEventHandler ObjectMouseMoveEventInf;
        /// <summary>
        /// 
        /// </summary>
        event SequenceDataUpateEventHandler SequenceDataUpdateEventInf;
        /// <summary>
        /// 
        /// </summary>
        event ProcessSequenceSourceEventHandler ProcessSequenceSourceInf;
        /// <param name="categoryRow"></param>
        /// <param name="fieldName"></param>
        /// <param name="caption"></param>
        /// <param name="value"></param>
        void SubscribeEditorRowToVGrid(string categoryRow, string fieldName, string caption, object value);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="categoryRow"></param>
        /// <param name="fieldName"></param>
        /// <param name="caption"></param>
        /// <param name="value"></param>
        /// <param name="option"></param>
        void SubscribeComboBoxRowToVGrid(string categoryRow, string fieldName, string caption, object value, object[] option);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="imagePath"></param>
        void InitializeIconSequence(string imagePath);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="categoryRow"></param>
        /// <param name="editorFieldName"></param>
        /// <returns></returns>
        object RetrieveVGridCategoryRowValue(string categoryRow, string editorFieldName);
        /// <summary>
        /// 
        /// </summary>
        double[] SigsenceSignal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        double[] SigsenceSequenceSourceData { get; }
        /// <summary>
        /// 
        /// </summary>
        DataTable tbObjectList { get; }
        /// <summary>
        /// 
        /// </summary>
        List<string> GetAvailableObjectSequence();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="controlName"></param>
        void SetSequenceSource(string controlName);
    }
}
