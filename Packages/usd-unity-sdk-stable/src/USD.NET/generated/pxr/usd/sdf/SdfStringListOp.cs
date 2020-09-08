//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace pxr {

public class SdfStringListOp : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal SdfStringListOp(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(SdfStringListOp obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~SdfStringListOp() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          UsdCsPINVOKE.delete_SdfStringListOp(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public SdfStringListOp() : this(UsdCsPINVOKE.new_SdfStringListOp(), true) {
  }

  public void Swap(SdfStringListOp rhs) {
    UsdCsPINVOKE.SdfStringListOp_Swap(swigCPtr, SdfStringListOp.getCPtr(rhs));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool HasKeys() {
    bool ret = UsdCsPINVOKE.SdfStringListOp_HasKeys(swigCPtr);
    return ret;
  }

  public bool IsExplicit() {
    bool ret = UsdCsPINVOKE.SdfStringListOp_IsExplicit(swigCPtr);
    return ret;
  }

  public StdStringVector GetExplicitItems() {
    StdStringVector ret = new StdStringVector(UsdCsPINVOKE.SdfStringListOp_GetExplicitItems(swigCPtr), false);
    return ret;
  }

  public StdStringVector GetAddedItems() {
    StdStringVector ret = new StdStringVector(UsdCsPINVOKE.SdfStringListOp_GetAddedItems(swigCPtr), false);
    return ret;
  }

  public StdStringVector GetPrependedItems() {
    StdStringVector ret = new StdStringVector(UsdCsPINVOKE.SdfStringListOp_GetPrependedItems(swigCPtr), false);
    return ret;
  }

  public StdStringVector GetAppendedItems() {
    StdStringVector ret = new StdStringVector(UsdCsPINVOKE.SdfStringListOp_GetAppendedItems(swigCPtr), false);
    return ret;
  }

  public StdStringVector GetDeletedItems() {
    StdStringVector ret = new StdStringVector(UsdCsPINVOKE.SdfStringListOp_GetDeletedItems(swigCPtr), false);
    return ret;
  }

  public StdStringVector GetOrderedItems() {
    StdStringVector ret = new StdStringVector(UsdCsPINVOKE.SdfStringListOp_GetOrderedItems(swigCPtr), false);
    return ret;
  }

  public StdStringVector GetItems(SdfListOpType type) {
    StdStringVector ret = new StdStringVector(UsdCsPINVOKE.SdfStringListOp_GetItems(swigCPtr, (int)type), false);
    return ret;
  }

  public void SetExplicitItems(StdStringVector items) {
    UsdCsPINVOKE.SdfStringListOp_SetExplicitItems(swigCPtr, StdStringVector.getCPtr(items));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetAddedItems(StdStringVector items) {
    UsdCsPINVOKE.SdfStringListOp_SetAddedItems(swigCPtr, StdStringVector.getCPtr(items));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetPrependedItems(StdStringVector items) {
    UsdCsPINVOKE.SdfStringListOp_SetPrependedItems(swigCPtr, StdStringVector.getCPtr(items));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetAppendedItems(StdStringVector items) {
    UsdCsPINVOKE.SdfStringListOp_SetAppendedItems(swigCPtr, StdStringVector.getCPtr(items));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetDeletedItems(StdStringVector items) {
    UsdCsPINVOKE.SdfStringListOp_SetDeletedItems(swigCPtr, StdStringVector.getCPtr(items));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetOrderedItems(StdStringVector items) {
    UsdCsPINVOKE.SdfStringListOp_SetOrderedItems(swigCPtr, StdStringVector.getCPtr(items));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetItems(StdStringVector items, SdfListOpType type) {
    UsdCsPINVOKE.SdfStringListOp_SetItems(swigCPtr, StdStringVector.getCPtr(items), (int)type);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Clear() {
    UsdCsPINVOKE.SdfStringListOp_Clear(swigCPtr);
  }

  public void ClearAndMakeExplicit() {
    UsdCsPINVOKE.SdfStringListOp_ClearAndMakeExplicit(swigCPtr);
  }

  public bool ReplaceOperations(SdfListOpType op, uint index, uint n, StdStringVector newItems) {
    bool ret = UsdCsPINVOKE.SdfStringListOp_ReplaceOperations(swigCPtr, (int)op, index, n, StdStringVector.getCPtr(newItems));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void ComposeOperations(SdfStringListOp stronger, SdfListOpType op) {
    UsdCsPINVOKE.SdfStringListOp_ComposeOperations(swigCPtr, SdfStringListOp.getCPtr(stronger), (int)op);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
