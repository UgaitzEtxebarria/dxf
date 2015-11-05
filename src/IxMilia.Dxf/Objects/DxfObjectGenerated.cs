﻿// Copyright (c) IxMilia.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

// The contents of this file are automatically generated by a tool, and should not be directly modified.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace IxMilia.Dxf.Objects
{

    public enum DxfObjectType
    {
        AcadProxyObject,
        AcdbDictionary,
        AcdbDictionaryWithDefault,
        AcdbPlaceHolder,
        DataTable,
        DimensionAssociativity,
        Field,
        GeoData,
        Group,
        IdBuffer,
        ImageDefinition,
        ImageDefinitionReactor,
        LayerFilter,
        LayerIndex,
        Layout,
        LightList,
        Material,
        MentalRayRenderSettings,
        MLineStyle,
        ObjectPointer,
        PlotSettings,
        RasterVariables,
        RenderEnvironment,
        RenderGlobal,
        SectionManager,
        SectionSettings,
        SortentsTable,
        SpatialFilter,
        SpatialIndex,
        SunStudy,
        TableStyle,
    }

    /// <summary>
    /// DxfObject class
    /// </summary>
    public partial class DxfObject : IDxfHasHandle
    {
        public uint Handle { get; set; }
        public uint OwnerHandle { get; set; }

        public string ObjectTypeString
        {
            get
            {
                switch (ObjectType)
                {
                    case DxfObjectType.AcadProxyObject:
                        return "ACAD_PROXY_OBJECT";
                    case DxfObjectType.AcdbDictionaryWithDefault:
                        return "ACDBDICTIONARYWDFLT";
                    case DxfObjectType.AcdbPlaceHolder:
                        return "ACDBPLACEHOLDER";
                    case DxfObjectType.DataTable:
                        return "DATATABLE";
                    case DxfObjectType.AcdbDictionary:
                        return "DICTIONARY";
                    case DxfObjectType.DimensionAssociativity:
                        return "DIMASSOC";
                    case DxfObjectType.Field:
                        return "FIELD";
                    case DxfObjectType.GeoData:
                        return "GEODATA";
                    case DxfObjectType.Group:
                        return "GROUP";
                    case DxfObjectType.IdBuffer:
                        return "IDBUFFER";
                    case DxfObjectType.ImageDefinition:
                        return "IMAGEDEF";
                    case DxfObjectType.ImageDefinitionReactor:
                        return "IMAGEDEF_REACTOR";
                    case DxfObjectType.LayerFilter:
                        return "LAYER_FILTER";
                    case DxfObjectType.LayerIndex:
                        return "LAYER_INDEX";
                    case DxfObjectType.Layout:
                        return "LAYOUT";
                    case DxfObjectType.LightList:
                        return "LIGHTLIST";
                    case DxfObjectType.Material:
                        return "MATERIAL";
                    case DxfObjectType.MLineStyle:
                        return "MLINESTYLE";
                    case DxfObjectType.ObjectPointer:
                        return "OBJECT_PTR";
                    case DxfObjectType.PlotSettings:
                        return "PLOTSETTINGS";
                    case DxfObjectType.RasterVariables:
                        return "RASTERVARIABLES";
                    case DxfObjectType.MentalRayRenderSettings:
                        return "MENTALRAYRENDERSETTINGS";
                    case DxfObjectType.RenderEnvironment:
                        return "RENDERENVIRONMENT";
                    case DxfObjectType.RenderGlobal:
                        return "RENDERGLOBAL";
                    case DxfObjectType.SectionManager:
                        return "SECTIONMANAGER";
                    case DxfObjectType.SectionSettings:
                        return "SECTIONSETTINGS";
                    case DxfObjectType.SortentsTable:
                        return "SORTENTSTABLE";
                    case DxfObjectType.SpatialFilter:
                        return "SPATIAL_FILTER";
                    case DxfObjectType.SpatialIndex:
                        return "SPATIAL_INDEX";
                    case DxfObjectType.SunStudy:
                        return "SUNSTUDY";
                    case DxfObjectType.TableStyle:
                        return "TABLESTYLE";
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        protected DxfObject(DxfObject other)
            : this()
        {
            this.Handle = other.Handle;
            this.OwnerHandle = other.OwnerHandle;
        }

        protected virtual void Initialize()
        {
            this.Handle = 0u;
            this.OwnerHandle = 0u;
        }

        protected virtual void AddValuePairs(List<DxfCodePair> pairs, DxfAcadVersion version, bool outputHandles)
        {
            pairs.Add(new DxfCodePair(0, ObjectTypeString));
            if (outputHandles)
            {
                pairs.Add(new DxfCodePair(5, UIntHandle(this.Handle)));
            }

            AddExtensionValuePairs(pairs, version, outputHandles);
            if (version >= DxfAcadVersion.R2000)
            {
                pairs.Add(new DxfCodePair(330, UIntHandle(this.OwnerHandle)));
            }

        }

        internal virtual bool TrySetPair(DxfCodePair pair)
        {
            switch (pair.Code)
            {
                case 5:
                    this.Handle = UIntHandle(pair.StringValue);
                    break;
                case 330:
                    this.OwnerHandle = UIntHandle(pair.StringValue);
                    break;
                default:
                    return false;
            }

            return true;
        }

        internal static DxfObject FromBuffer(DxfCodePairBufferReader buffer)
        {
            var first = buffer.Peek();
            buffer.Advance();
            DxfObject obj;
            switch (first.StringValue)
            {
                case "ACAD_PROXY_OBJECT":
                    obj = new DxfAcadProxyObject();
                    break;
                case "ACDBDICTIONARYWDFLT":
                    obj = new DxfAcdbDictionaryWithDefault();
                    break;
                case "ACDBPLACEHOLDER":
                    obj = new DxfAcdbPlaceHolder();
                    break;
                case "DATATABLE":
                    obj = new DxfDataTable();
                    break;
                case "DICTIONARY":
                    obj = new DxfDictionary();
                    break;
                case "DIMASSOC":
                    obj = new DxfDimensionAssociativity();
                    break;
                case "FIELD":
                    obj = new DxfField();
                    break;
                case "GEODATA":
                    obj = new DxfGeoData();
                    break;
                case "GROUP":
                    obj = new DxfGroup();
                    break;
                case "IDBUFFER":
                    obj = new DxfIdBuffer();
                    break;
                case "IMAGEDEF":
                    obj = new DxfImageDefinition();
                    break;
                case "IMAGEDEF_REACTOR":
                    obj = new DxfImageDefinitionReactor();
                    break;
                case "LAYER_FILTER":
                    obj = new DxfLayerFilter();
                    break;
                case "LAYER_INDEX":
                    obj = new DxfLayerIndex();
                    break;
                case "LAYOUT":
                    obj = new DxfLayout();
                    break;
                case "LIGHTLIST":
                    obj = new DxfLightList();
                    break;
                case "MATERIAL":
                    obj = new DxfMaterial();
                    break;
                case "MLINESTYLE":
                    obj = new DxfMLineStyle();
                    break;
                case "OBJECT_PTR":
                    obj = new DxfObjectPointer();
                    break;
                case "PLOTSETTINGS":
                    obj = new DxfPlotSettings();
                    break;
                case "RASTERVARIABLES":
                    obj = new DxfRasterVariables();
                    break;
                case "MENTALRAYRENDERSETTINGS":
                    obj = new DxfMentalRayRenderSettings();
                    break;
                case "RENDERENVIRONMENT":
                    obj = new DxfRenderEnvironment();
                    break;
                case "RENDERGLOBAL":
                    obj = new DxfRenderGlobal();
                    break;
                case "SECTIONMANAGER":
                    obj = new DxfSectionManager();
                    break;
                case "SECTIONSETTINGS":
                    obj = new DxfSectionSettings();
                    break;
                case "SORTENTSTABLE":
                    obj = new DxfSortentsTable();
                    break;
                case "SPATIAL_FILTER":
                    obj = new DxfSpatialFilter();
                    break;
                case "SPATIAL_INDEX":
                    obj = new DxfSpatialIndex();
                    break;
                case "SUNSTUDY":
                    obj = new DxfSunStudy();
                    break;
                case "TABLESTYLE":
                    obj = new DxfTableStyle();
                    break;
                default:
                    SwallowObject(buffer);
                    obj = null;
                    break;
            }

            if (obj != null)
            {
                obj = obj.PopulateFromBuffer(buffer);
            }

            return obj;
        }
    }

}

// Copyright (c) IxMilia.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

// This line is required for T4 template generation to work. 
// Copyright (c) IxMilia.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

// This line is required for T4 template generation to work. 

