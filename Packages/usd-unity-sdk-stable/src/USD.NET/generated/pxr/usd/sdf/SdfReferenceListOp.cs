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

public class SdfReferenceListOp : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal SdfReferenceListOp(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(SdfReferenceListOp obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~SdfReferenceListOp() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          UsdCsPINVOKE.delete_SdfReferenceListOp(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public SdfReferenceListOp() : this(UsdCsPINVOKE.new_SdfReferenceListOp(), true) {
  }

  public void Swap(SdfReferenceListOp rhs) {
    UsdCsPINVOKE.SdfReferenceListOp_Swap(swigCPtr, SdfReferenceListOp.getCPtr(rhs));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool HasKeys() {
    bool ret = UsdCsPINVOKE.SdfReferenceListOp_HasKeys(swigCPtr);
    return ret;
  }

  public bool IsExplicit() {
    bool ret = UsdCsPINVOKE.SdfReferenceListOp_IsExplicit(swigCPtr);
    return ret;
  }

  public StdReferenceVector GetExplicitItems() {
    StdReferenceVector ret = new StdReferenceVector(UsdCsPINVOKE.SdfReferenceListOp_GetExplicitItems(swigCPtr), false);
    return ret;
  }

  public StdReferenceVector GetAddedItems() {
    StdReferenceVector ret = new StdReferenceVector(UsdCsPINVOKE.SdfReferenceListOp_GetAddedItems(swigCPtr), false);
    return ret;
  }

  public StdReferenceVector GetPrependedItems() {
    StdReferenceVector ret = new StdReferenceVector(UsdCsPINVOKE.SdfReferenceListOp_GetPrependedItems(swigCPtr), false);
    return ret;
  }

  public StdReferenceVector GetAppendedItems() {
    StdReferenceVector ret = new StdReferenceVector(UsdCsPINVOKE.SdfReferenceListOp_GetAppendedItems(swigCPtr), false);
    return ret;
  }

  public StdReferenceVector GetDeletedItems() {
    StdReferenceVector ret = new StdReferenceVector(UsdCsPINVOKE.SdfReferenceListOp_GetDeletedItems(swigCPtr), false);
    return ret;
  }

  public StdReferenceVector GetOrderedItems() {
    StdReferenceVector ret = new StdReferenceVector(UsdCsPINVOKE.SdfReferenceListOp_GetOrderedItems(swigCPtr), false);
    return ret;
  }

  public StdReferenceVector GetItems(SdfListOpType type) {
    StdReferenceVector ret = new StdReferenceVector(UsdCsPINVOKE.SdfReferenceListOp_GetItems(swigCPtr, (int)type), false);
    return ret;
  }

  public void SetExplicitItems(StdReferenceVector items) {
    UsdCsPINVOKE.SdfReferenceListOp_SetExplicitItems(swigCPtr, StdReferenceVector.getCPtr(items));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetAddedItems(StdReferenceVector items) {
    UsdCsPINVOKE.SdfReferenceListOp_SetAddedItems(swigCPtr, StdReferenceVector.getCPtr(items));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetPrependedItems(StdReferenceVector items) {
    UsdCsPINVOKE.SdfReferenceListOp_SetPrependedItems(swigCPtr, StdReferenceVector.getCPtr(items));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetAppendedItems(StdReferenceVector items) {
    UsdCsPINVOKE.SdfReferenceListOp_SetAppendedItems(swigCPtr, StdReferenceVector.getCPtr(items));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetDeletedItems(StdReferenceVector items) {
    UsdCsPINVOKE.SdfReferenceListOp_SetDeletedItems(swigCPtr, StdReferenceVector.getCPtr(items));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetOrderedItems(StdReferenceVector items) {
    UsdCsPINVOKE.SdfReferenceListOp_SetOrderedItems(swigCPtr, StdReferenceVector.getCPtr(items));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetItems(StdReferenceVector items, SdfListOpType type) {
    UsdCsPINVOKE.SdfReferenceListOp_SetItems(swigCPtr, StdReferenceVector.getCPtr(items), (int)type);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Clear() {
    UsdCsPINVOKE.SdfReferenceListOp_Clear(swigCPtr);
  }

  public void ClearAndMakeExplicit() {
    UsdCsPINVOKE.SdfReferenceListOp_ClearAndMakeExplicit(swigCPtr);
  }

  public bool ReplaceOperations(SdfListOpType op, uint index, uint n, StdReferenceVector newItems) {
    bool ret = UsdCsPINVOKE.SdfReferenceListOp_ReplaceOperations(swigCPtr, (int)op, index, n, StdReferenceVector.getCPtr(newItems));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void ComposeOperations(SdfReferenceListOp stronger, SdfListOpType op) {
    UsdCsPINVOKE.SdfReferenceListOp_ComposeOperations(swigCPtr, SdfReferenceListOp.getCPtr(stronger), (int)op);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
