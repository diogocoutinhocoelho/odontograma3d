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

public class UsdSkelAnimQuery : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal UsdSkelAnimQuery(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(UsdSkelAnimQuery obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~UsdSkelAnimQuery() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          UsdCsPINVOKE.delete_UsdSkelAnimQuery(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public UsdSkelAnimQuery() : this(UsdCsPINVOKE.new_UsdSkelAnimQuery(), true) {
  }

  public bool IsValid() {
    bool ret = UsdCsPINVOKE.UsdSkelAnimQuery_IsValid(swigCPtr);
    return ret;
  }

  public UsdPrim GetPrim() {
    UsdPrim ret = new UsdPrim(UsdCsPINVOKE.UsdSkelAnimQuery_GetPrim(swigCPtr), true);
    return ret;
  }

  public bool ComputeJointLocalTransformComponents(VtVec3fArray translations, VtQuatfArray rotations, VtVec3hArray scales, UsdTimeCode time) {
    bool ret = UsdCsPINVOKE.UsdSkelAnimQuery_ComputeJointLocalTransformComponents__SWIG_0(swigCPtr, VtVec3fArray.getCPtr(translations), VtQuatfArray.getCPtr(rotations), VtVec3hArray.getCPtr(scales), UsdTimeCode.getCPtr(time));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool ComputeJointLocalTransformComponents(VtVec3fArray translations, VtQuatfArray rotations, VtVec3hArray scales) {
    bool ret = UsdCsPINVOKE.UsdSkelAnimQuery_ComputeJointLocalTransformComponents__SWIG_1(swigCPtr, VtVec3fArray.getCPtr(translations), VtQuatfArray.getCPtr(rotations), VtVec3hArray.getCPtr(scales));
    return ret;
  }

  public bool ComputeBlendShapeWeights(VtFloatArray weights, UsdTimeCode time) {
    bool ret = UsdCsPINVOKE.UsdSkelAnimQuery_ComputeBlendShapeWeights__SWIG_0(swigCPtr, VtFloatArray.getCPtr(weights), UsdTimeCode.getCPtr(time));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool ComputeBlendShapeWeights(VtFloatArray weights) {
    bool ret = UsdCsPINVOKE.UsdSkelAnimQuery_ComputeBlendShapeWeights__SWIG_1(swigCPtr, VtFloatArray.getCPtr(weights));
    return ret;
  }

  public bool GetJointTransformTimeSamples(StdDoubleVector times) {
    bool ret = UsdCsPINVOKE.UsdSkelAnimQuery_GetJointTransformTimeSamples(swigCPtr, StdDoubleVector.getCPtr(times));
    return ret;
  }

  public bool GetJointTransformTimeSamplesInInterval(GfInterval interval, StdDoubleVector times) {
    bool ret = UsdCsPINVOKE.UsdSkelAnimQuery_GetJointTransformTimeSamplesInInterval(swigCPtr, GfInterval.getCPtr(interval), StdDoubleVector.getCPtr(times));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetJointTransformAttributes(UsdAttributeVector attrs) {
    bool ret = UsdCsPINVOKE.UsdSkelAnimQuery_GetJointTransformAttributes(swigCPtr, UsdAttributeVector.getCPtr(attrs));
    return ret;
  }

  public bool JointTransformsMightBeTimeVarying() {
    bool ret = UsdCsPINVOKE.UsdSkelAnimQuery_JointTransformsMightBeTimeVarying(swigCPtr);
    return ret;
  }

  public bool GetBlendShapeWeightTimeSamples(StdDoubleVector attrs) {
    bool ret = UsdCsPINVOKE.UsdSkelAnimQuery_GetBlendShapeWeightTimeSamples(swigCPtr, StdDoubleVector.getCPtr(attrs));
    return ret;
  }

  public bool GetBlendShapeWeightTimeSamplesInInterval(GfInterval interval, StdDoubleVector times) {
    bool ret = UsdCsPINVOKE.UsdSkelAnimQuery_GetBlendShapeWeightTimeSamplesInInterval(swigCPtr, GfInterval.getCPtr(interval), StdDoubleVector.getCPtr(times));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool BlendShapeWeightsMightBeTimeVarying() {
    bool ret = UsdCsPINVOKE.UsdSkelAnimQuery_BlendShapeWeightsMightBeTimeVarying(swigCPtr);
    return ret;
  }

  public VtTokenArray GetJointOrder() {
    VtTokenArray ret = new VtTokenArray(UsdCsPINVOKE.UsdSkelAnimQuery_GetJointOrder(swigCPtr), true);
    return ret;
  }

  public VtTokenArray GetBlendShapeOrder() {
    VtTokenArray ret = new VtTokenArray(UsdCsPINVOKE.UsdSkelAnimQuery_GetBlendShapeOrder(swigCPtr), true);
    return ret;
  }

  public string GetDescription() {
    string ret = UsdCsPINVOKE.UsdSkelAnimQuery_GetDescription(swigCPtr);
    return ret;
  }

}

}