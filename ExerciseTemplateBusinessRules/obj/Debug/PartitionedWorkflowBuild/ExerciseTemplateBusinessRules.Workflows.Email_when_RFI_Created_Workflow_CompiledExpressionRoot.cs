namespace ExerciseTemplateBusinessRules.Workflows.Email_when_RFI_Created {
    
    #line 17 "c:\SP2013\ExerciseTemplateBusinessRules\ExerciseTemplateBusinessRules\Workflows\Email when RFI Created\Workflow.xaml"
    using System;
    
    #line default
    #line hidden
    
    #line 1 "c:\SP2013\ExerciseTemplateBusinessRules\ExerciseTemplateBusinessRules\Workflows\Email when RFI Created\Workflow.xaml"
    using System.Collections;
    
    #line default
    #line hidden
    
    #line 18 "c:\SP2013\ExerciseTemplateBusinessRules\ExerciseTemplateBusinessRules\Workflows\Email when RFI Created\Workflow.xaml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    
    #line 1 "c:\SP2013\ExerciseTemplateBusinessRules\ExerciseTemplateBusinessRules\Workflows\Email when RFI Created\Workflow.xaml"
    using System.Activities;
    
    #line default
    #line hidden
    
    #line 1 "c:\SP2013\ExerciseTemplateBusinessRules\ExerciseTemplateBusinessRules\Workflows\Email when RFI Created\Workflow.xaml"
    using System.Activities.Expressions;
    
    #line default
    #line hidden
    
    #line 1 "c:\SP2013\ExerciseTemplateBusinessRules\ExerciseTemplateBusinessRules\Workflows\Email when RFI Created\Workflow.xaml"
    using System.Activities.Statements;
    
    #line default
    #line hidden
    
    #line 19 "c:\SP2013\ExerciseTemplateBusinessRules\ExerciseTemplateBusinessRules\Workflows\Email when RFI Created\Workflow.xaml"
    using System.Data;
    
    #line default
    #line hidden
    
    #line 20 "c:\SP2013\ExerciseTemplateBusinessRules\ExerciseTemplateBusinessRules\Workflows\Email when RFI Created\Workflow.xaml"
    using System.Text;
    
    #line default
    #line hidden
    
    #line 21 "c:\SP2013\ExerciseTemplateBusinessRules\ExerciseTemplateBusinessRules\Workflows\Email when RFI Created\Workflow.xaml"
    using Microsoft.Activities;
    
    #line default
    #line hidden
    
    #line 22 "c:\SP2013\ExerciseTemplateBusinessRules\ExerciseTemplateBusinessRules\Workflows\Email when RFI Created\Workflow.xaml"
    using System.Collections.ObjectModel;
    
    #line default
    #line hidden
    
    #line 1 "c:\SP2013\ExerciseTemplateBusinessRules\ExerciseTemplateBusinessRules\Workflows\Email when RFI Created\Workflow.xaml"
    using System.Activities.XamlIntegration;
    
    #line default
    #line hidden
    
    
    public partial class Workflow : System.Activities.XamlIntegration.ICompiledExpressionRoot {
        
        private System.Activities.Activity rootActivity;
        
        private object dataContextActivities;
        
        private bool forImplementation = true;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public string GetLanguage() {
            return "C#";
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public object InvokeExpression(int expressionId, System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext) {
            if ((this.rootActivity == null)) {
                this.rootActivity = this;
            }
            if ((this.dataContextActivities == null)) {
                this.dataContextActivities = Workflow_TypedDataContext2.GetDataContextActivitiesHelper(this.rootActivity, this.forImplementation);
            }
            if ((expressionId == 0)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Workflow_TypedDataContext2(locations, activityContext, true);
                }
                Workflow_TypedDataContext2 refDataContext0 = ((Workflow_TypedDataContext2)(cachedCompiledDataContext[0]));
                return refDataContext0.GetLocation<string>(refDataContext0.ValueType___Expr0Get, refDataContext0.ValueType___Expr0Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 1)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Workflow_TypedDataContext2(locations, activityContext, true);
                }
                Workflow_TypedDataContext2 refDataContext1 = ((Workflow_TypedDataContext2)(cachedCompiledDataContext[0]));
                return refDataContext1.GetLocation<Microsoft.Activities.DynamicValue>(refDataContext1.ValueType___Expr1Get, refDataContext1.ValueType___Expr1Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 2)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Workflow_TypedDataContext2(locations, activityContext, true);
                }
                Workflow_TypedDataContext2 refDataContext2 = ((Workflow_TypedDataContext2)(cachedCompiledDataContext[0]));
                return refDataContext2.GetLocation<string>(refDataContext2.ValueType___Expr2Get, refDataContext2.ValueType___Expr2Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 3)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Workflow_TypedDataContext2(locations, activityContext, true);
                }
                Workflow_TypedDataContext2 refDataContext3 = ((Workflow_TypedDataContext2)(cachedCompiledDataContext[0]));
                return refDataContext3.GetLocation<string>(refDataContext3.ValueType___Expr3Get, refDataContext3.ValueType___Expr3Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 4)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Workflow_TypedDataContext2(locations, activityContext, true);
                }
                Workflow_TypedDataContext2 refDataContext4 = ((Workflow_TypedDataContext2)(cachedCompiledDataContext[0]));
                return refDataContext4.GetLocation<string>(refDataContext4.ValueType___Expr4Get, refDataContext4.ValueType___Expr4Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 5)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Workflow_TypedDataContext2(locations, activityContext, true);
                }
                Workflow_TypedDataContext2 refDataContext5 = ((Workflow_TypedDataContext2)(cachedCompiledDataContext[0]));
                return refDataContext5.GetLocation<string>(refDataContext5.ValueType___Expr5Get, refDataContext5.ValueType___Expr5Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 6)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Workflow_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext2_ForReadOnly valDataContext6 = ((Workflow_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext6.ValueType___Expr6Get();
            }
            if ((expressionId == 7)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Workflow_TypedDataContext2(locations, activityContext, true);
                }
                Workflow_TypedDataContext2 refDataContext7 = ((Workflow_TypedDataContext2)(cachedCompiledDataContext[0]));
                return refDataContext7.GetLocation<string>(refDataContext7.ValueType___Expr7Get, refDataContext7.ValueType___Expr7Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 8)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Workflow_TypedDataContext2(locations, activityContext, true);
                }
                Workflow_TypedDataContext2 refDataContext8 = ((Workflow_TypedDataContext2)(cachedCompiledDataContext[0]));
                return refDataContext8.GetLocation<string>(refDataContext8.ValueType___Expr8Get, refDataContext8.ValueType___Expr8Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 9)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Workflow_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext2_ForReadOnly valDataContext9 = ((Workflow_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext9.ValueType___Expr9Get();
            }
            if ((expressionId == 10)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Workflow_TypedDataContext2(locations, activityContext, true);
                }
                Workflow_TypedDataContext2 refDataContext10 = ((Workflow_TypedDataContext2)(cachedCompiledDataContext[0]));
                return refDataContext10.GetLocation<System.Collections.ObjectModel.Collection<string>>(refDataContext10.ValueType___Expr10Get, refDataContext10.ValueType___Expr10Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 11)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Workflow_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext2_ForReadOnly valDataContext11 = ((Workflow_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext11.ValueType___Expr11Get();
            }
            if ((expressionId == 12)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Workflow_TypedDataContext2(locations, activityContext, true);
                }
                Workflow_TypedDataContext2 refDataContext12 = ((Workflow_TypedDataContext2)(cachedCompiledDataContext[0]));
                return refDataContext12.GetLocation<string>(refDataContext12.ValueType___Expr12Get, refDataContext12.ValueType___Expr12Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 13)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Workflow_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext2_ForReadOnly valDataContext13 = ((Workflow_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext13.ValueType___Expr13Get();
            }
            if ((expressionId == 14)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Workflow_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext2_ForReadOnly valDataContext14 = ((Workflow_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext14.ValueType___Expr14Get();
            }
            if ((expressionId == 15)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Workflow_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext2_ForReadOnly valDataContext15 = ((Workflow_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext15.ValueType___Expr15Get();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public object InvokeExpression(int expressionId, System.Collections.Generic.IList<System.Activities.Location> locations) {
            if ((this.rootActivity == null)) {
                this.rootActivity = this;
            }
            if ((expressionId == 0)) {
                Workflow_TypedDataContext2 refDataContext0 = new Workflow_TypedDataContext2(locations, true);
                return refDataContext0.GetLocation<string>(refDataContext0.ValueType___Expr0Get, refDataContext0.ValueType___Expr0Set);
            }
            if ((expressionId == 1)) {
                Workflow_TypedDataContext2 refDataContext1 = new Workflow_TypedDataContext2(locations, true);
                return refDataContext1.GetLocation<Microsoft.Activities.DynamicValue>(refDataContext1.ValueType___Expr1Get, refDataContext1.ValueType___Expr1Set);
            }
            if ((expressionId == 2)) {
                Workflow_TypedDataContext2 refDataContext2 = new Workflow_TypedDataContext2(locations, true);
                return refDataContext2.GetLocation<string>(refDataContext2.ValueType___Expr2Get, refDataContext2.ValueType___Expr2Set);
            }
            if ((expressionId == 3)) {
                Workflow_TypedDataContext2 refDataContext3 = new Workflow_TypedDataContext2(locations, true);
                return refDataContext3.GetLocation<string>(refDataContext3.ValueType___Expr3Get, refDataContext3.ValueType___Expr3Set);
            }
            if ((expressionId == 4)) {
                Workflow_TypedDataContext2 refDataContext4 = new Workflow_TypedDataContext2(locations, true);
                return refDataContext4.GetLocation<string>(refDataContext4.ValueType___Expr4Get, refDataContext4.ValueType___Expr4Set);
            }
            if ((expressionId == 5)) {
                Workflow_TypedDataContext2 refDataContext5 = new Workflow_TypedDataContext2(locations, true);
                return refDataContext5.GetLocation<string>(refDataContext5.ValueType___Expr5Get, refDataContext5.ValueType___Expr5Set);
            }
            if ((expressionId == 6)) {
                Workflow_TypedDataContext2_ForReadOnly valDataContext6 = new Workflow_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext6.ValueType___Expr6Get();
            }
            if ((expressionId == 7)) {
                Workflow_TypedDataContext2 refDataContext7 = new Workflow_TypedDataContext2(locations, true);
                return refDataContext7.GetLocation<string>(refDataContext7.ValueType___Expr7Get, refDataContext7.ValueType___Expr7Set);
            }
            if ((expressionId == 8)) {
                Workflow_TypedDataContext2 refDataContext8 = new Workflow_TypedDataContext2(locations, true);
                return refDataContext8.GetLocation<string>(refDataContext8.ValueType___Expr8Get, refDataContext8.ValueType___Expr8Set);
            }
            if ((expressionId == 9)) {
                Workflow_TypedDataContext2_ForReadOnly valDataContext9 = new Workflow_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext9.ValueType___Expr9Get();
            }
            if ((expressionId == 10)) {
                Workflow_TypedDataContext2 refDataContext10 = new Workflow_TypedDataContext2(locations, true);
                return refDataContext10.GetLocation<System.Collections.ObjectModel.Collection<string>>(refDataContext10.ValueType___Expr10Get, refDataContext10.ValueType___Expr10Set);
            }
            if ((expressionId == 11)) {
                Workflow_TypedDataContext2_ForReadOnly valDataContext11 = new Workflow_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext11.ValueType___Expr11Get();
            }
            if ((expressionId == 12)) {
                Workflow_TypedDataContext2 refDataContext12 = new Workflow_TypedDataContext2(locations, true);
                return refDataContext12.GetLocation<string>(refDataContext12.ValueType___Expr12Get, refDataContext12.ValueType___Expr12Set);
            }
            if ((expressionId == 13)) {
                Workflow_TypedDataContext2_ForReadOnly valDataContext13 = new Workflow_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext13.ValueType___Expr13Get();
            }
            if ((expressionId == 14)) {
                Workflow_TypedDataContext2_ForReadOnly valDataContext14 = new Workflow_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext14.ValueType___Expr14Get();
            }
            if ((expressionId == 15)) {
                Workflow_TypedDataContext2_ForReadOnly valDataContext15 = new Workflow_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext15.ValueType___Expr15Get();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool CanExecuteExpression(string expressionText, bool isReference, System.Collections.Generic.IList<System.Activities.LocationReference> locations, out int expressionId) {
            if (((isReference == true) 
                        && ((expressionText == "currentSiteURL") 
                        && (Workflow_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 0;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "props") 
                        && (Workflow_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 1;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Id") 
                        && (Workflow_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 2;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Priority") 
                        && (Workflow_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 3;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Details") 
                        && (Workflow_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 4;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "RecommendedOPR") 
                        && (Workflow_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 5;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "props") 
                        && (Workflow_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 6;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Title") 
                        && (Workflow_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 7;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "POCEmail") 
                        && (Workflow_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 8;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "POCEmail") 
                        && (Workflow_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 9;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "recipients") 
                        && (Workflow_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 10;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "currentSiteURL + \"/Lists/RFI/DispForm.aspx?ID=\" + Id") 
                        && (Workflow_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 11;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "currentItemURL") 
                        && (Workflow_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 12;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "recipients") 
                        && (Workflow_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 13;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"<b>Title:</b> \" + Title +\n\n\"<br/><b>ID:</b> \" + Id +\n\n\"<br/><b>Priority:</b> \" +" +
                            " Priority +\n\n\"<br/><b>Recommended OPR:</b> \" + RecommendedOPR +\n\n\"<br/><b>Detail" +
                            "s:</b> \" + Details +\n\n\"<br/><br/><a href=\'\" + currentItemURL + \"\'>View RFI</a>\"") 
                        && (Workflow_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 14;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"Your RFI: \" + Title") 
                        && (Workflow_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 15;
                return true;
            }
            expressionId = -1;
            return false;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public System.Collections.Generic.IList<string> GetRequiredLocations(int expressionId) {
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public System.Linq.Expressions.Expression GetExpressionTreeForExpression(int expressionId, System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) {
            if ((expressionId == 0)) {
                return new Workflow_TypedDataContext2(locationReferences).@__Expr0GetTree();
            }
            if ((expressionId == 1)) {
                return new Workflow_TypedDataContext2(locationReferences).@__Expr1GetTree();
            }
            if ((expressionId == 2)) {
                return new Workflow_TypedDataContext2(locationReferences).@__Expr2GetTree();
            }
            if ((expressionId == 3)) {
                return new Workflow_TypedDataContext2(locationReferences).@__Expr3GetTree();
            }
            if ((expressionId == 4)) {
                return new Workflow_TypedDataContext2(locationReferences).@__Expr4GetTree();
            }
            if ((expressionId == 5)) {
                return new Workflow_TypedDataContext2(locationReferences).@__Expr5GetTree();
            }
            if ((expressionId == 6)) {
                return new Workflow_TypedDataContext2_ForReadOnly(locationReferences).@__Expr6GetTree();
            }
            if ((expressionId == 7)) {
                return new Workflow_TypedDataContext2(locationReferences).@__Expr7GetTree();
            }
            if ((expressionId == 8)) {
                return new Workflow_TypedDataContext2(locationReferences).@__Expr8GetTree();
            }
            if ((expressionId == 9)) {
                return new Workflow_TypedDataContext2_ForReadOnly(locationReferences).@__Expr9GetTree();
            }
            if ((expressionId == 10)) {
                return new Workflow_TypedDataContext2(locationReferences).@__Expr10GetTree();
            }
            if ((expressionId == 11)) {
                return new Workflow_TypedDataContext2_ForReadOnly(locationReferences).@__Expr11GetTree();
            }
            if ((expressionId == 12)) {
                return new Workflow_TypedDataContext2(locationReferences).@__Expr12GetTree();
            }
            if ((expressionId == 13)) {
                return new Workflow_TypedDataContext2_ForReadOnly(locationReferences).@__Expr13GetTree();
            }
            if ((expressionId == 14)) {
                return new Workflow_TypedDataContext2_ForReadOnly(locationReferences).@__Expr14GetTree();
            }
            if ((expressionId == 15)) {
                return new Workflow_TypedDataContext2_ForReadOnly(locationReferences).@__Expr15GetTree();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow_TypedDataContext0 : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext0(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal static object GetDataContextActivitiesHelper(System.Activities.Activity compiledRoot, bool forImplementation) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetDataContextActivities(compiledRoot, forImplementation);
            }
            
            internal static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
            }
            
            public static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 0))) {
                    return false;
                }
                expectedLocationsCount = 0;
                return true;
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow_TypedDataContext0_ForReadOnly : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal static object GetDataContextActivitiesHelper(System.Activities.Activity compiledRoot, bool forImplementation) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetDataContextActivities(compiledRoot, forImplementation);
            }
            
            internal static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
            }
            
            public static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 0))) {
                    return false;
                }
                expectedLocationsCount = 0;
                return true;
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow_TypedDataContext1 : Workflow_TypedDataContext0 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext1(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 0))) {
                    return false;
                }
                expectedLocationsCount = 0;
                return Workflow_TypedDataContext0.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow_TypedDataContext1_ForReadOnly : Workflow_TypedDataContext0_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 0))) {
                    return false;
                }
                expectedLocationsCount = 0;
                return Workflow_TypedDataContext0_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow_TypedDataContext2 : Workflow_TypedDataContext1 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext2(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected Microsoft.Activities.DynamicValue props {
                get {
                    return ((Microsoft.Activities.DynamicValue)(this.GetVariableValue((0 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((0 + locationsOffset), value);
                }
            }
            
            protected string POCEmail {
                get {
                    return ((string)(this.GetVariableValue((1 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((1 + locationsOffset), value);
                }
            }
            
            protected System.Collections.ObjectModel.Collection<string> recipients {
                get {
                    return ((System.Collections.ObjectModel.Collection<string>)(this.GetVariableValue((2 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((2 + locationsOffset), value);
                }
            }
            
            protected string Id {
                get {
                    return ((string)(this.GetVariableValue((3 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((3 + locationsOffset), value);
                }
            }
            
            protected string Title {
                get {
                    return ((string)(this.GetVariableValue((4 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((4 + locationsOffset), value);
                }
            }
            
            protected string Priority {
                get {
                    return ((string)(this.GetVariableValue((5 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((5 + locationsOffset), value);
                }
            }
            
            protected string RecommendedOPR {
                get {
                    return ((string)(this.GetVariableValue((6 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((6 + locationsOffset), value);
                }
            }
            
            protected string Details {
                get {
                    return ((string)(this.GetVariableValue((7 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((7 + locationsOffset), value);
                }
            }
            
            protected string currentItemURL {
                get {
                    return ((string)(this.GetVariableValue((8 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((8 + locationsOffset), value);
                }
            }
            
            protected string currentSiteURL {
                get {
                    return ((string)(this.GetVariableValue((9 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((9 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr0GetTree() {
                
                #line 61 "C:\SP2013\EXERCISETEMPLATEBUSINESSRULES\EXERCISETEMPLATEBUSINESSRULES\WORKFLOWS\EMAIL WHEN RFI CREATED\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
          currentSiteURL;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr0Get() {
                
                #line 61 "C:\SP2013\EXERCISETEMPLATEBUSINESSRULES\EXERCISETEMPLATEBUSINESSRULES\WORKFLOWS\EMAIL WHEN RFI CREATED\WORKFLOW.XAML"
                return 
          currentSiteURL;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr0Get() {
                this.GetValueTypeValues();
                return this.@__Expr0Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr0Set(string value) {
                
                #line 61 "C:\SP2013\EXERCISETEMPLATEBUSINESSRULES\EXERCISETEMPLATEBUSINESSRULES\WORKFLOWS\EMAIL WHEN RFI CREATED\WORKFLOW.XAML"
                
          currentSiteURL = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr0Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr0Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr1GetTree() {
                
                #line 82 "C:\SP2013\EXERCISETEMPLATEBUSINESSRULES\EXERCISETEMPLATEBUSINESSRULES\WORKFLOWS\EMAIL WHEN RFI CREATED\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<Microsoft.Activities.DynamicValue>> expression = () => 
          props;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Microsoft.Activities.DynamicValue @__Expr1Get() {
                
                #line 82 "C:\SP2013\EXERCISETEMPLATEBUSINESSRULES\EXERCISETEMPLATEBUSINESSRULES\WORKFLOWS\EMAIL WHEN RFI CREATED\WORKFLOW.XAML"
                return 
          props;
                
                #line default
                #line hidden
            }
            
            public Microsoft.Activities.DynamicValue ValueType___Expr1Get() {
                this.GetValueTypeValues();
                return this.@__Expr1Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr1Set(Microsoft.Activities.DynamicValue value) {
                
                #line 82 "C:\SP2013\EXERCISETEMPLATEBUSINESSRULES\EXERCISETEMPLATEBUSINESSRULES\WORKFLOWS\EMAIL WHEN RFI CREATED\WORKFLOW.XAML"
                
          props = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr1Set(Microsoft.Activities.DynamicValue value) {
                this.GetValueTypeValues();
                this.@__Expr1Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr2GetTree() {
                
                #line 97 "C:\SP2013\EXERCISETEMPLATEBUSINESSRULES\EXERCISETEMPLATEBUSINESSRULES\WORKFLOWS\EMAIL WHEN RFI CREATED\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
          Id;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr2Get() {
                
                #line 97 "C:\SP2013\EXERCISETEMPLATEBUSINESSRULES\EXERCISETEMPLATEBUSINESSRULES\WORKFLOWS\EMAIL WHEN RFI CREATED\WORKFLOW.XAML"
                return 
          Id;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr2Get() {
                this.GetValueTypeValues();
                return this.@__Expr2Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr2Set(string value) {
                
                #line 97 "C:\SP2013\EXERCISETEMPLATEBUSINESSRULES\EXERCISETEMPLATEBUSINESSRULES\WORKFLOWS\EMAIL WHEN RFI CREATED\WORKFLOW.XAML"
                
          Id = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr2Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr2Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr3GetTree() {
                
                #line 103 "C:\SP2013\EXERCISETEMPLATEBUSINESSRULES\EXERCISETEMPLATEBUSINESSRULES\WORKFLOWS\EMAIL WHEN RFI CREATED\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
          Priority;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr3Get() {
                
                #line 103 "C:\SP2013\EXERCISETEMPLATEBUSINESSRULES\EXERCISETEMPLATEBUSINESSRULES\WORKFLOWS\EMAIL WHEN RFI CREATED\WORKFLOW.XAML"
                return 
          Priority;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr3Get() {
                this.GetValueTypeValues();
                return this.@__Expr3Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr3Set(string value) {
                
                #line 103 "C:\SP2013\EXERCISETEMPLATEBUSINESSRULES\EXERCISETEMPLATEBUSINESSRULES\WORKFLOWS\EMAIL WHEN RFI CREATED\WORKFLOW.XAML"
                
          Priority = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr3Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr3Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr4GetTree() {
                
                #line 109 "C:\SP2013\EXERCISETEMPLATEBUSINESSRULES\EXERCISETEMPLATEBUSINESSRULES\WORKFLOWS\EMAIL WHEN RFI CREATED\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
          Details;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr4Get() {
                
                #line 109 "C:\SP2013\EXERCISETEMPLATEBUSINESSRULES\EXERCISETEMPLATEBUSINESSRULES\WORKFLOWS\EMAIL WHEN RFI CREATED\WORKFLOW.XAML"
                return 
          Details;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr4Get() {
                this.GetValueTypeValues();
                return this.@__Expr4Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr4Set(string value) {
                
                #line 109 "C:\SP2013\EXERCISETEMPLATEBUSINESSRULES\EXERCISETEMPLATEBUSINESSRULES\WORKFLOWS\EMAIL WHEN RFI CREATED\WORKFLOW.XAML"
                
          Details = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr4Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr4Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr5GetTree() {
                
                #line 106 "C:\SP2013\EXERCISETEMPLATEBUSINESSRULES\EXERCISETEMPLATEBUSINESSRULES\WORKFLOWS\EMAIL WHEN RFI CREATED\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
          RecommendedOPR;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr5Get() {
                
                #line 106 "C:\SP2013\EXERCISETEMPLATEBUSINESSRULES\EXERCISETEMPLATEBUSINESSRULES\WORKFLOWS\EMAIL WHEN RFI CREATED\WORKFLOW.XAML"
                return 
          RecommendedOPR;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr5Get() {
                this.GetValueTypeValues();
                return this.@__Expr5Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr5Set(string value) {
                
                #line 106 "C:\SP2013\EXERCISETEMPLATEBUSINESSRULES\EXERCISETEMPLATEBUSINESSRULES\WORKFLOWS\EMAIL WHEN RFI CREATED\WORKFLOW.XAML"
                
          RecommendedOPR = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr5Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr5Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr7GetTree() {
                
                #line 100 "C:\SP2013\EXERCISETEMPLATEBUSINESSRULES\EXERCISETEMPLATEBUSINESSRULES\WORKFLOWS\EMAIL WHEN RFI CREATED\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
          Title;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr7Get() {
                
                #line 100 "C:\SP2013\EXERCISETEMPLATEBUSINESSRULES\EXERCISETEMPLATEBUSINESSRULES\WORKFLOWS\EMAIL WHEN RFI CREATED\WORKFLOW.XAML"
                return 
          Title;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr7Get() {
                this.GetValueTypeValues();
                return this.@__Expr7Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr7Set(string value) {
                
                #line 100 "C:\SP2013\EXERCISETEMPLATEBUSINESSRULES\EXERCISETEMPLATEBUSINESSRULES\WORKFLOWS\EMAIL WHEN RFI CREATED\WORKFLOW.XAML"
                
          Title = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr7Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr7Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr8GetTree() {
                
                #line 94 "C:\SP2013\EXERCISETEMPLATEBUSINESSRULES\EXERCISETEMPLATEBUSINESSRULES\WORKFLOWS\EMAIL WHEN RFI CREATED\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
          POCEmail;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr8Get() {
                
                #line 94 "C:\SP2013\EXERCISETEMPLATEBUSINESSRULES\EXERCISETEMPLATEBUSINESSRULES\WORKFLOWS\EMAIL WHEN RFI CREATED\WORKFLOW.XAML"
                return 
          POCEmail;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr8Get() {
                this.GetValueTypeValues();
                return this.@__Expr8Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr8Set(string value) {
                
                #line 94 "C:\SP2013\EXERCISETEMPLATEBUSINESSRULES\EXERCISETEMPLATEBUSINESSRULES\WORKFLOWS\EMAIL WHEN RFI CREATED\WORKFLOW.XAML"
                
          POCEmail = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr8Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr8Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr10GetTree() {
                
                #line 117 "C:\SP2013\EXERCISETEMPLATEBUSINESSRULES\EXERCISETEMPLATEBUSINESSRULES\WORKFLOWS\EMAIL WHEN RFI CREATED\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.ObjectModel.Collection<string>>> expression = () => 
          recipients;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.ObjectModel.Collection<string> @__Expr10Get() {
                
                #line 117 "C:\SP2013\EXERCISETEMPLATEBUSINESSRULES\EXERCISETEMPLATEBUSINESSRULES\WORKFLOWS\EMAIL WHEN RFI CREATED\WORKFLOW.XAML"
                return 
          recipients;
                
                #line default
                #line hidden
            }
            
            public System.Collections.ObjectModel.Collection<string> ValueType___Expr10Get() {
                this.GetValueTypeValues();
                return this.@__Expr10Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr10Set(System.Collections.ObjectModel.Collection<string> value) {
                
                #line 117 "C:\SP2013\EXERCISETEMPLATEBUSINESSRULES\EXERCISETEMPLATEBUSINESSRULES\WORKFLOWS\EMAIL WHEN RFI CREATED\WORKFLOW.XAML"
                
          recipients = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr10Set(System.Collections.ObjectModel.Collection<string> value) {
                this.GetValueTypeValues();
                this.@__Expr10Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr12GetTree() {
                
                #line 129 "C:\SP2013\EXERCISETEMPLATEBUSINESSRULES\EXERCISETEMPLATEBUSINESSRULES\WORKFLOWS\EMAIL WHEN RFI CREATED\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
          currentItemURL;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr12Get() {
                
                #line 129 "C:\SP2013\EXERCISETEMPLATEBUSINESSRULES\EXERCISETEMPLATEBUSINESSRULES\WORKFLOWS\EMAIL WHEN RFI CREATED\WORKFLOW.XAML"
                return 
          currentItemURL;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr12Get() {
                this.GetValueTypeValues();
                return this.@__Expr12Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr12Set(string value) {
                
                #line 129 "C:\SP2013\EXERCISETEMPLATEBUSINESSRULES\EXERCISETEMPLATEBUSINESSRULES\WORKFLOWS\EMAIL WHEN RFI CREATED\WORKFLOW.XAML"
                
          currentItemURL = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr12Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr12Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 10))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 10);
                }
                expectedLocationsCount = 10;
                if (((locationReferences[(offset + 0)].Name != "props") 
                            || (locationReferences[(offset + 0)].Type != typeof(Microsoft.Activities.DynamicValue)))) {
                    return false;
                }
                if (((locationReferences[(offset + 1)].Name != "POCEmail") 
                            || (locationReferences[(offset + 1)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 2)].Name != "recipients") 
                            || (locationReferences[(offset + 2)].Type != typeof(System.Collections.ObjectModel.Collection<string>)))) {
                    return false;
                }
                if (((locationReferences[(offset + 3)].Name != "Id") 
                            || (locationReferences[(offset + 3)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 4)].Name != "Title") 
                            || (locationReferences[(offset + 4)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 5)].Name != "Priority") 
                            || (locationReferences[(offset + 5)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 6)].Name != "RecommendedOPR") 
                            || (locationReferences[(offset + 6)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 7)].Name != "Details") 
                            || (locationReferences[(offset + 7)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 8)].Name != "currentItemURL") 
                            || (locationReferences[(offset + 8)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 9)].Name != "currentSiteURL") 
                            || (locationReferences[(offset + 9)].Type != typeof(string)))) {
                    return false;
                }
                return Workflow_TypedDataContext1.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow_TypedDataContext2_ForReadOnly : Workflow_TypedDataContext1_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected Microsoft.Activities.DynamicValue props {
                get {
                    return ((Microsoft.Activities.DynamicValue)(this.GetVariableValue((0 + locationsOffset))));
                }
            }
            
            protected string POCEmail {
                get {
                    return ((string)(this.GetVariableValue((1 + locationsOffset))));
                }
            }
            
            protected System.Collections.ObjectModel.Collection<string> recipients {
                get {
                    return ((System.Collections.ObjectModel.Collection<string>)(this.GetVariableValue((2 + locationsOffset))));
                }
            }
            
            protected string Id {
                get {
                    return ((string)(this.GetVariableValue((3 + locationsOffset))));
                }
            }
            
            protected string Title {
                get {
                    return ((string)(this.GetVariableValue((4 + locationsOffset))));
                }
            }
            
            protected string Priority {
                get {
                    return ((string)(this.GetVariableValue((5 + locationsOffset))));
                }
            }
            
            protected string RecommendedOPR {
                get {
                    return ((string)(this.GetVariableValue((6 + locationsOffset))));
                }
            }
            
            protected string Details {
                get {
                    return ((string)(this.GetVariableValue((7 + locationsOffset))));
                }
            }
            
            protected string currentItemURL {
                get {
                    return ((string)(this.GetVariableValue((8 + locationsOffset))));
                }
            }
            
            protected string currentSiteURL {
                get {
                    return ((string)(this.GetVariableValue((9 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr6GetTree() {
                
                #line 89 "C:\SP2013\EXERCISETEMPLATEBUSINESSRULES\EXERCISETEMPLATEBUSINESSRULES\WORKFLOWS\EMAIL WHEN RFI CREATED\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<Microsoft.Activities.DynamicValue>> expression = () => 
          props;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Microsoft.Activities.DynamicValue @__Expr6Get() {
                
                #line 89 "C:\SP2013\EXERCISETEMPLATEBUSINESSRULES\EXERCISETEMPLATEBUSINESSRULES\WORKFLOWS\EMAIL WHEN RFI CREATED\WORKFLOW.XAML"
                return 
          props;
                
                #line default
                #line hidden
            }
            
            public Microsoft.Activities.DynamicValue ValueType___Expr6Get() {
                this.GetValueTypeValues();
                return this.@__Expr6Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr9GetTree() {
                
                #line 122 "C:\SP2013\EXERCISETEMPLATEBUSINESSRULES\EXERCISETEMPLATEBUSINESSRULES\WORKFLOWS\EMAIL WHEN RFI CREATED\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
          POCEmail;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr9Get() {
                
                #line 122 "C:\SP2013\EXERCISETEMPLATEBUSINESSRULES\EXERCISETEMPLATEBUSINESSRULES\WORKFLOWS\EMAIL WHEN RFI CREATED\WORKFLOW.XAML"
                return 
          POCEmail;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr9Get() {
                this.GetValueTypeValues();
                return this.@__Expr9Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr11GetTree() {
                
                #line 134 "C:\SP2013\EXERCISETEMPLATEBUSINESSRULES\EXERCISETEMPLATEBUSINESSRULES\WORKFLOWS\EMAIL WHEN RFI CREATED\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
          currentSiteURL + "/Lists/RFI/DispForm.aspx?ID=" + Id;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr11Get() {
                
                #line 134 "C:\SP2013\EXERCISETEMPLATEBUSINESSRULES\EXERCISETEMPLATEBUSINESSRULES\WORKFLOWS\EMAIL WHEN RFI CREATED\WORKFLOW.XAML"
                return 
          currentSiteURL + "/Lists/RFI/DispForm.aspx?ID=" + Id;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr11Get() {
                this.GetValueTypeValues();
                return this.@__Expr11Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr13GetTree() {
                
                #line 161 "C:\SP2013\EXERCISETEMPLATEBUSINESSRULES\EXERCISETEMPLATEBUSINESSRULES\WORKFLOWS\EMAIL WHEN RFI CREATED\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.ObjectModel.Collection<string>>> expression = () => 
          recipients;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.ObjectModel.Collection<string> @__Expr13Get() {
                
                #line 161 "C:\SP2013\EXERCISETEMPLATEBUSINESSRULES\EXERCISETEMPLATEBUSINESSRULES\WORKFLOWS\EMAIL WHEN RFI CREATED\WORKFLOW.XAML"
                return 
          recipients;
                
                #line default
                #line hidden
            }
            
            public System.Collections.ObjectModel.Collection<string> ValueType___Expr13Get() {
                this.GetValueTypeValues();
                return this.@__Expr13Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr14GetTree() {
                
                #line 141 "C:\SP2013\EXERCISETEMPLATEBUSINESSRULES\EXERCISETEMPLATEBUSINESSRULES\WORKFLOWS\EMAIL WHEN RFI CREATED\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
          "<b>Title:</b> " + Title +

"<br/><b>ID:</b> " + Id +

"<br/><b>Priority:</b> " + Priority +

"<br/><b>Recommended OPR:</b> " + RecommendedOPR +

"<br/><b>Details:</b> " + Details +

"<br/><br/><a href='" + currentItemURL + "'>View RFI</a>";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr14Get() {
                
                #line 141 "C:\SP2013\EXERCISETEMPLATEBUSINESSRULES\EXERCISETEMPLATEBUSINESSRULES\WORKFLOWS\EMAIL WHEN RFI CREATED\WORKFLOW.XAML"
                return 
          "<b>Title:</b> " + Title +

"<br/><b>ID:</b> " + Id +

"<br/><b>Priority:</b> " + Priority +

"<br/><b>Recommended OPR:</b> " + RecommendedOPR +

"<br/><b>Details:</b> " + Details +

"<br/><br/><a href='" + currentItemURL + "'>View RFI</a>";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr14Get() {
                this.GetValueTypeValues();
                return this.@__Expr14Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr15GetTree() {
                
                #line 156 "C:\SP2013\EXERCISETEMPLATEBUSINESSRULES\EXERCISETEMPLATEBUSINESSRULES\WORKFLOWS\EMAIL WHEN RFI CREATED\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
          "Your RFI: " + Title;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr15Get() {
                
                #line 156 "C:\SP2013\EXERCISETEMPLATEBUSINESSRULES\EXERCISETEMPLATEBUSINESSRULES\WORKFLOWS\EMAIL WHEN RFI CREATED\WORKFLOW.XAML"
                return 
          "Your RFI: " + Title;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr15Get() {
                this.GetValueTypeValues();
                return this.@__Expr15Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 10))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 10);
                }
                expectedLocationsCount = 10;
                if (((locationReferences[(offset + 0)].Name != "props") 
                            || (locationReferences[(offset + 0)].Type != typeof(Microsoft.Activities.DynamicValue)))) {
                    return false;
                }
                if (((locationReferences[(offset + 1)].Name != "POCEmail") 
                            || (locationReferences[(offset + 1)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 2)].Name != "recipients") 
                            || (locationReferences[(offset + 2)].Type != typeof(System.Collections.ObjectModel.Collection<string>)))) {
                    return false;
                }
                if (((locationReferences[(offset + 3)].Name != "Id") 
                            || (locationReferences[(offset + 3)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 4)].Name != "Title") 
                            || (locationReferences[(offset + 4)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 5)].Name != "Priority") 
                            || (locationReferences[(offset + 5)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 6)].Name != "RecommendedOPR") 
                            || (locationReferences[(offset + 6)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 7)].Name != "Details") 
                            || (locationReferences[(offset + 7)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 8)].Name != "currentItemURL") 
                            || (locationReferences[(offset + 8)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 9)].Name != "currentSiteURL") 
                            || (locationReferences[(offset + 9)].Type != typeof(string)))) {
                    return false;
                }
                return Workflow_TypedDataContext1_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
    }
}
