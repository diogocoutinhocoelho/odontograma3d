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

public class PcpLayerStackPtr : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal PcpLayerStackPtr(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PcpLayerStackPtr obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PcpLayerStackPtr() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          UsdCsPINVOKE.delete_PcpLayerStackPtr(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public PcpLayerStackPtr(PcpLayerStack ptr) : this(UsdCsPINVOKE.new_PcpLayerStackPtr(PcpLayerStack.getCPtr(ptr)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public PcpLayerStack __deref__() {
    global::System.IntPtr cPtr = UsdCsPINVOKE.PcpLayerStackPtr___deref__(swigCPtr);
    PcpLayerStack ret = (cPtr == global::System.IntPtr.Zero) ? null : new PcpLayerStack(cPtr, true);
    return ret;
  }

  public PcpLayerStackIdentifier GetIdentifier() {
    PcpLayerStackIdentifier ret = new PcpLayerStackIdentifier(UsdCsPINVOKE.PcpLayerStackPtr_GetIdentifier(swigCPtr), false);
    return ret;
  }

  public SdfLayerRefPtrVector GetLayers() {
    SdfLayerRefPtrVector ret = new SdfLayerRefPtrVector(UsdCsPINVOKE.PcpLayerStackPtr_GetLayers(swigCPtr), false);
    return ret;
  }

  public SdfLayerHandleVector GetSessionLayers() {
    SdfLayerHandleVector ret = new SdfLayerHandleVector(UsdCsPINVOKE.PcpLayerStackPtr_GetSessionLayers(swigCPtr), true);
    return ret;
  }

  public SdfLayerTreeHandle GetLayerTree() {
    SdfLayerTreeHandle ret = new SdfLayerTreeHandle(UsdCsPINVOKE.PcpLayerStackPtr_GetLayerTree(swigCPtr), false);
    return ret;
  }

  public SdfLayerOffset GetLayerOffsetForLayer(SdfLayerHandle arg0) {
    global::System.IntPtr cPtr = UsdCsPINVOKE.PcpLayerStackPtr_GetLayerOffsetForLayer__SWIG_0(swigCPtr, SdfLayerHandle.getCPtr(arg0));
    SdfLayerOffset ret = (cPtr == global::System.IntPtr.Zero) ? null : new SdfLayerOffset(cPtr, false);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SdfLayerOffset GetLayerOffsetForLayer(SdfLayer arg0) {
    global::System.IntPtr cPtr = UsdCsPINVOKE.PcpLayerStackPtr_GetLayerOffsetForLayer__SWIG_1(swigCPtr, SdfLayer.getCPtr(arg0));
    SdfLayerOffset ret = (cPtr == global::System.IntPtr.Zero) ? null : new SdfLayerOffset(cPtr, false);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SdfLayerOffset GetLayerOffsetForLayer(uint layerIdx) {
    global::System.IntPtr cPtr = UsdCsPINVOKE.PcpLayerStackPtr_GetLayerOffsetForLayer__SWIG_2(swigCPtr, layerIdx);
    SdfLayerOffset ret = (cPtr == global::System.IntPtr.Zero) ? null : new SdfLayerOffset(cPtr, false);
    return ret;
  }

  public SWIGTYPE_p_std__setT_std__string_t GetResolvedAssetPaths() {
    SWIGTYPE_p_std__setT_std__string_t ret = new SWIGTYPE_p_std__setT_std__string_t(UsdCsPINVOKE.PcpLayerStackPtr_GetResolvedAssetPaths(swigCPtr), false);
    return ret;
  }

  public SWIGTYPE_p_std__setT_std__string_t GetMutedLayers() {
    SWIGTYPE_p_std__setT_std__string_t ret = new SWIGTYPE_p_std__setT_std__string_t(UsdCsPINVOKE.PcpLayerStackPtr_GetMutedLayers(swigCPtr), false);
    return ret;
  }

  public SWIGTYPE_p_PcpErrorVector GetLocalErrors() {
    SWIGTYPE_p_PcpErrorVector ret = new SWIGTYPE_p_PcpErrorVector(UsdCsPINVOKE.PcpLayerStackPtr_GetLocalErrors(swigCPtr), true);
    return ret;
  }

  public bool HasLayer(SdfLayerHandle layer) {
    bool ret = UsdCsPINVOKE.PcpLayerStackPtr_HasLayer__SWIG_0(swigCPtr, SdfLayerHandle.getCPtr(layer));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool HasLayer(SdfLayer layer) {
    bool ret = UsdCsPINVOKE.PcpLayerStackPtr_HasLayer__SWIG_1(swigCPtr, SdfLayer.getCPtr(layer));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_std__mapT_SdfPath_SdfPath_std__lessT_SdfPath_t_t GetRelocatesSourceToTarget() {
    SWIGTYPE_p_std__mapT_SdfPath_SdfPath_std__lessT_SdfPath_t_t ret = new SWIGTYPE_p_std__mapT_SdfPath_SdfPath_std__lessT_SdfPath_t_t(UsdCsPINVOKE.PcpLayerStackPtr_GetRelocatesSourceToTarget(swigCPtr), false);
    return ret;
  }

  public SWIGTYPE_p_std__mapT_SdfPath_SdfPath_std__lessT_SdfPath_t_t GetRelocatesTargetToSource() {
    SWIGTYPE_p_std__mapT_SdfPath_SdfPath_std__lessT_SdfPath_t_t ret = new SWIGTYPE_p_std__mapT_SdfPath_SdfPath_std__lessT_SdfPath_t_t(UsdCsPINVOKE.PcpLayerStackPtr_GetRelocatesTargetToSource(swigCPtr), false);
    return ret;
  }

  public SWIGTYPE_p_std__mapT_SdfPath_SdfPath_std__lessT_SdfPath_t_t GetIncrementalRelocatesSourceToTarget() {
    SWIGTYPE_p_std__mapT_SdfPath_SdfPath_std__lessT_SdfPath_t_t ret = new SWIGTYPE_p_std__mapT_SdfPath_SdfPath_std__lessT_SdfPath_t_t(UsdCsPINVOKE.PcpLayerStackPtr_GetIncrementalRelocatesSourceToTarget(swigCPtr), false);
    return ret;
  }

  public SWIGTYPE_p_std__mapT_SdfPath_SdfPath_std__lessT_SdfPath_t_t GetIncrementalRelocatesTargetToSource() {
    SWIGTYPE_p_std__mapT_SdfPath_SdfPath_std__lessT_SdfPath_t_t ret = new SWIGTYPE_p_std__mapT_SdfPath_SdfPath_std__lessT_SdfPath_t_t(UsdCsPINVOKE.PcpLayerStackPtr_GetIncrementalRelocatesTargetToSource(swigCPtr), false);
    return ret;
  }

  public SdfPathVector GetPathsToPrimsWithRelocates() {
    SdfPathVector ret = new SdfPathVector(UsdCsPINVOKE.PcpLayerStackPtr_GetPathsToPrimsWithRelocates(swigCPtr), false);
    return ret;
  }

}

}
