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

public class UsdSkelAnimMapper : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal UsdSkelAnimMapper(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(UsdSkelAnimMapper obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~UsdSkelAnimMapper() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          UsdCsPINVOKE.delete_UsdSkelAnimMapper(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public UsdSkelAnimMapper() : this(UsdCsPINVOKE.new_UsdSkelAnimMapper__SWIG_0(), true) {
  }

  public UsdSkelAnimMapper(uint size) : this(UsdCsPINVOKE.new_UsdSkelAnimMapper__SWIG_1(size), true) {
  }

  public UsdSkelAnimMapper(VtTokenArray sourceOrder, VtTokenArray targetOrder) : this(UsdCsPINVOKE.new_UsdSkelAnimMapper__SWIG_2(VtTokenArray.getCPtr(sourceOrder), VtTokenArray.getCPtr(targetOrder)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public UsdSkelAnimMapper(TfToken sourceOrder, uint sourceOrderSize, TfToken targetOrder, uint targetOrderSize) : this(UsdCsPINVOKE.new_UsdSkelAnimMapper__SWIG_3(TfToken.getCPtr(sourceOrder), sourceOrderSize, TfToken.getCPtr(targetOrder), targetOrderSize), true) {
  }

  public bool Remap(VtValue source, VtValue target, int elementSize, VtValue defaultValue) {
    bool ret = UsdCsPINVOKE.UsdSkelAnimMapper_Remap__SWIG_3(swigCPtr, VtValue.getCPtr(source), VtValue.getCPtr(target), elementSize, VtValue.getCPtr(defaultValue));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Remap(VtValue source, VtValue target, int elementSize) {
    bool ret = UsdCsPINVOKE.UsdSkelAnimMapper_Remap__SWIG_4(swigCPtr, VtValue.getCPtr(source), VtValue.getCPtr(target), elementSize);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Remap(VtValue source, VtValue target) {
    bool ret = UsdCsPINVOKE.UsdSkelAnimMapper_Remap__SWIG_5(swigCPtr, VtValue.getCPtr(source), VtValue.getCPtr(target));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool IsIdentity() {
    bool ret = UsdCsPINVOKE.UsdSkelAnimMapper_IsIdentity(swigCPtr);
    return ret;
  }

  public bool IsSparse() {
    bool ret = UsdCsPINVOKE.UsdSkelAnimMapper_IsSparse(swigCPtr);
    return ret;
  }

  public bool IsNull() {
    bool ret = UsdCsPINVOKE.UsdSkelAnimMapper_IsNull(swigCPtr);
    return ret;
  }

  public uint size() {
    uint ret = UsdCsPINVOKE.UsdSkelAnimMapper_size(swigCPtr);
    return ret;
  }

}

}
