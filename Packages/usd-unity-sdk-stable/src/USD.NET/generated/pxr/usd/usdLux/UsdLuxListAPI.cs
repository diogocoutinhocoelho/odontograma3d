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

public class UsdLuxListAPI : UsdAPISchemaBase {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal UsdLuxListAPI(global::System.IntPtr cPtr, bool cMemoryOwn) : base(UsdCsPINVOKE.UsdLuxListAPI_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(UsdLuxListAPI obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~UsdLuxListAPI() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          UsdCsPINVOKE.delete_UsdLuxListAPI(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public UsdLuxListAPI(UsdPrim prim) : this(UsdCsPINVOKE.new_UsdLuxListAPI__SWIG_0(UsdPrim.getCPtr(prim)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public UsdLuxListAPI() : this(UsdCsPINVOKE.new_UsdLuxListAPI__SWIG_1(), true) {
  }

  public UsdLuxListAPI(UsdSchemaBase schemaObj) : this(UsdCsPINVOKE.new_UsdLuxListAPI__SWIG_2(UsdSchemaBase.getCPtr(schemaObj)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public new static TfTokenVector GetSchemaAttributeNames(bool includeInherited) {
    TfTokenVector ret = new TfTokenVector(UsdCsPINVOKE.UsdLuxListAPI_GetSchemaAttributeNames__SWIG_0(includeInherited), false);
    return ret;
  }

  public new static TfTokenVector GetSchemaAttributeNames() {
    TfTokenVector ret = new TfTokenVector(UsdCsPINVOKE.UsdLuxListAPI_GetSchemaAttributeNames__SWIG_1(), false);
    return ret;
  }

  public static UsdLuxListAPI Get(UsdStageWeakPtr stage, SdfPath path) {
    UsdLuxListAPI ret = new UsdLuxListAPI(UsdCsPINVOKE.UsdLuxListAPI_Get(UsdStageWeakPtr.getCPtr(stage), SdfPath.getCPtr(path)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static UsdLuxListAPI Apply(UsdPrim prim) {
    UsdLuxListAPI ret = new UsdLuxListAPI(UsdCsPINVOKE.UsdLuxListAPI_Apply(UsdPrim.getCPtr(prim)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute GetLightListCacheBehaviorAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdLuxListAPI_GetLightListCacheBehaviorAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateLightListCacheBehaviorAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdLuxListAPI_CreateLightListCacheBehaviorAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateLightListCacheBehaviorAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdLuxListAPI_CreateLightListCacheBehaviorAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateLightListCacheBehaviorAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdLuxListAPI_CreateLightListCacheBehaviorAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdRelationship GetLightListRel() {
    UsdRelationship ret = new UsdRelationship(UsdCsPINVOKE.UsdLuxListAPI_GetLightListRel(swigCPtr), true);
    return ret;
  }

  public UsdRelationship CreateLightListRel() {
    UsdRelationship ret = new UsdRelationship(UsdCsPINVOKE.UsdLuxListAPI_CreateLightListRel(swigCPtr), true);
    return ret;
  }

  public SWIGTYPE_p_std__setT_SdfPath_t ComputeLightList(UsdLuxListAPI.ComputeMode mode) {
    SWIGTYPE_p_std__setT_SdfPath_t ret = new SWIGTYPE_p_std__setT_SdfPath_t(UsdCsPINVOKE.UsdLuxListAPI_ComputeLightList(swigCPtr, (int)mode), true);
    return ret;
  }

  public void StoreLightList(SWIGTYPE_p_std__setT_SdfPath_t arg0) {
    UsdCsPINVOKE.UsdLuxListAPI_StoreLightList(swigCPtr, SWIGTYPE_p_std__setT_SdfPath_t.getCPtr(arg0));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void InvalidateLightList() {
    UsdCsPINVOKE.UsdLuxListAPI_InvalidateLightList(swigCPtr);
  }

  public enum ComputeMode {
    ComputeModeConsultModelHierarchyCache,
    ComputeModeIgnoreCache
  }

}

}
