using System.Web;
using System.Web.Optimization;

namespace BaseProject
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            BundleTable.EnableOptimizations = false;

            //Smart Application Styles
            bundles.Add(new StyleBundle("~/Content/smart_theme/dist/css").Include(
          "~/Content/smart_theme/dist/css/vendors.bundle.css",
          "~/Content/smart_theme/dist/css/app.bundle.css",
          "~/Content/smart_theme/dist/css/skins/skin-master.css",
          "~/Content/css/plugins/ionRangeSlider/ion.rangeSlider.css",
          "~/Content/smart_theme/dist/css/page-invoice.css",
          "~/Content/smart_theme/dist/css/datagrid/datatables/datatables.bundle.css",
          "~/Content/smart_theme/dist/css/statistics/chartjs/chartjs.css",
          "~/Content/smart_theme/dist/css/statistics/c3/c3.css",
          "~/Content/smart_theme/dist/css/formplugins/select2/select2.bundle.css",
          "~/Content/smart_theme/dist/css/formplugins/dropzone/dropzone.css",
          //"~/Content/css/plugins/hijriDatepicker/bootstrap-datetimepicker.min.css",
          "~/Content/smart_theme/dist/css/filepond.css",
          "~/Content/smart_theme/dist/smart_uploader/filepond-plugin-image-overlay.css",
          "~/Content/smart_theme/dist/css/fa-solid.css",
          "~/Content/css/plugins/jsTree/style.min.css",
          "~/Content/smart_theme/dist/css/formplugins/ion-rangeslider/ion-rangeslider.css",
          "~/Content/smart_theme/dist/css/fa-brands.css",
          "~/Content/smart_theme/dist/smart_uploader/filepond-plugin-image-preview.css",
           "~/Content/smart_theme/dist/smart_uploader/filepond-plugin-file-poster.css",
          "~/Content/smart_theme/dist/css/notifications/sweetalert2/sweetalert2.css",
          "~/Content/smart_theme/dist/literallycanvas/_assets/literallycanvas.css"
          ));
            //bootstrap RightToLeft css
            bundles.Add(new StyleBundle("~/Content/css-rtl").Include
            ("~/Content/css/bootstrap.rtl.css"));

            //bootstrap pagination css
            bundles.Add(new StyleBundle("~/Content/simplePagination").Include
            ("~/Content/SimplePaging/simplePagination.css"));

            //bootstrap LeftToRight css
            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/css/bootstrap.min.css"));

            // Application Styles
            bundles.Add(new StyleBundle("~/Content/AppStyleSHeet").Include(
                      "~/Content/appStyleSheet.css"));
            // Font Awesome icons
            bundles.Add(new StyleBundle("~/font-awesome/css").Include(
                      "~/Content/font-awesome/css/font-awesome.css", new CssRewriteUrlTransform()));

            // Gallery
            bundles.Add(new StyleBundle("~/Gallery/css").Include(
                      "~/Content/css/plugins/blueimp/css/blueimp-gallery.min.css", new CssRewriteUrlTransform()));

            bundles.Add(new StyleBundle("~/Content/style").Include(
        "~/Content/css/animate.css",
         "~/Content/css/style.css"));

            bundles.Add(new StyleBundle("~/Content/icheck").Include(
                 "~/Content/css/plugins/iCheck/custom.css"));

            // toastr notification styles
            bundles.Add(new StyleBundle("~/plugins/toastrStyles").Include(
                      "~/Content/css/plugins/toastr/toastr.min.css"));
            //bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
            //           "~/Content/js/plugins/jquery-ui/jquery-ui.min.js"));

            bundles.Add(new StyleBundle("~/Content/gritter").Include(
                "~/Content/js/plugins/gritter/jquery.gritter.css"));

            bundles.Add(new StyleBundle("~/Content/jsTree").Include(
                "~/Content/css/plugins/jsTree/style.min.css"));

            // jQueryUI CSSC
            bundles.Add(new StyleBundle("~/Content/css/jquery-ui/jqueryuiStyles").Include(
                        "~/Content/css/plugins/jQueryUI/jquery-ui.css"));

            // fullCalendar styles
            bundles.Add(new StyleBundle("~/Content/fullCalendarStyles").Include(
                      "~/Content/plugins/fullcalendar/fullcalendar.css"));

            // RangeSlider Styles
            bundles.Add(new StyleBundle("~/Content/rangeSlider").Include(
                  "~/Content/css/plugins/ionRangeSlider/ion.rangeSlider.css"));

            //awesome-checkbox
            bundles.Add(new StyleBundle("~/Content/awesome-checkbox").Include(
               "~/Content/css/plugins/awesome-bootstrap-checkbox/awesome-bootstrap-checkbox.css"));

            //clockpicker styles
            bundles.Add(new StyleBundle("~/Content/clockpicker").Include(
               "~/Content/css/plugins/clockpicker/clockpicker.css"));

            //touchspin style
            bundles.Add(new StyleBundle("~/Content/bootstrap-touchspin").Include(
               "~/Content/css/plugins/bootstrap-tagsinput/bootstrap-tagsinput.css"));

            // colorpicker
            bundles.Add(new StyleBundle("~/Content/colorpicker").Include(
                "~/Content/css/plugins/colorpicker/bootstrap-colorpicker.min.css"));

            //cropper styles
            bundles.Add(new StyleBundle("~/Content/cropper").Include(
            "~/Content/css/plugins/cropper/cropper.min.css"));

            //select2 styles
            bundles.Add(new StyleBundle("~/Content/select2").Include(
            "~/Content/css/plugins/select2/select2.min.css"));

            //select2 bootstrap4
            bundles.Add(new StyleBundle("~/Content/select2bootstrap4").Include(
            "~/Content/css/plugins/select2/select2-bootstrap4.min.css"));

            //select2 bootstrap4
            bundles.Add(new StyleBundle("~/Content/bootstrap-touchspin").Include(
            "~/Content/css/plugins/touchspin/jquery.bootstrap-touchspin.min.css"));

            //duallistbox
            bundles.Add(new StyleBundle("~/Content/duallistbox").Include(
            "~/Content/css/plugins/dualListbox/bootstrap-duallistbox.min.css"));

            //datepicker3 
            bundles.Add(new StyleBundle("~/Content/datepicker3").Include(
            "~/Content/css/plugins/datapicker/datepicker3.css"));

            ////hijridatepicker 
            //bundles.Add(new StyleBundle("~/Content/hijridatepicker").Include(
            //"~/Content/css/plugins/test/bootstrap-datetimepicker.min.css"));

            //bundles.Add(new ScriptBundle("~/Content/hijridatepickerJs").Include(
            //    "~/Content/js/plugins/hijriDatepicker/bootstrap-hijri-datetimepicker.min.js"));
            //jasny-bootstrap
            bundles.Add(new StyleBundle("~/Content/jasny").Include(
             "~/Content/css/plugins/jasny/jasny-bootstrap.min.css"));

            //Nouislider Styles
            bundles.Add(new StyleBundle("~/Content/nouislider").Include(
            "~/Content/css/plugins/nouslider/jquery.nouislider.css"));

            //Switchery Styles
            bundles.Add(new StyleBundle("~/Content/Switchery").Include(
             "~/Content/css/plugins/switchery/switchery.css"));

            //bootstrap-markdown
            bundles.Add(new StyleBundle("~/Content/bootstrap-markdown").Include(
             "~/Content/css/plugins/bootstrap-markdown/bootstrap-markdown.min.css"));

            //sweetalert
            bundles.Add(new StyleBundle("~/css/plugins/sweetalert").Include(
             "~/Content/css/plugins/sweetalert/sweetalert.css"));

            //footer
            bundles.Add(new StyleBundle("~/Content/footer").Include(
             "~/Content/css/plugins/footable/footable.core.css"));

            //dataTables
            bundles.Add(new StyleBundle("~/css/plugins/dataTables").Include(
             "~/Content/css/plugins/dataTables/datatables.min.css"));

            //footable
            bundles.Add(new StyleBundle("~/css/plugins/footable").Include(
                "~/Content/css/plugins/footable/footable.core.css"));

            ///*************Script***********///

            //basic
            bundles.Add(new StyleBundle("~/Content/basic").Include(
             "~/Content/css/plugins/dropzone/basic.css"));

            //dropzone
            bundles.Add(new StyleBundle("~/Content/dropzone").Include(
             "~/Content/css/plugins/dropzone/dropzone.css"));


            //codemirror
            bundles.Add(new StyleBundle("~/Content/codemirror").Include(
             "~/Content/css/plugins/codemirror/codemirror.css"));

            // //Rich Text Editor
            bundles.Add(new StyleBundle("~/Content/smart_theme/dist/EditorCss").Include(
           "~/Content/smart_theme/dist/Editor/summernote.css"));

            ///*************Script***********///



            // icheck
            bundles.Add(new ScriptBundle("~/plugins/icheck").Include(
                      "~/Content/js/plugins/iCheck/icheck.min.js"));

            // Bootstrap
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Content/js/popper.min.js",
                      "~/Content/js/bootstrap.js"));
            //nestable
            bundles.Add(new ScriptBundle("~/js/plugins/nestable").Include(
                     "~/Content/js/plugins/nestable/jquery.nestable.js"));
            // Inspinia script
            bundles.Add(new ScriptBundle("~/bundles/inspinia").Include(
                      "~/Content/js/plugins/pace/pace.min.js",
                      "~/Content/js/inspinia.js"));

            // SimplePagination
            bundles.Add(new ScriptBundle("~/bundles/simplePagination").Include(
                      "~/Content/SimplePaging/jquery.simplePagination.js"));

            //metisMenu
            bundles.Add(new ScriptBundle("~/bundles/metisMenu").Include(
                    "~/Content/js/plugins/metisMenu/jquery.metisMenu.js"
                ));

            // SlimScroll
            bundles.Add(new ScriptBundle("~/plugins/slimScroll").Include(
                      "~/Content/js/plugins/slimscroll/jquery.slimscroll.min.js"));

            //Gallery

            bundles.Add(new ScriptBundle("~/plugins/Blueimp-gallery").Include(
               "~/Content/js/plugins/blueimp/query.blueimp-gallery.min.js"));

            // Flot chart
            bundles.Add(new ScriptBundle("~/plugins/flot").Include(
                      "~/Content/js/plugins/flot/jquery.flot.js",
                      "~/Content/js/plugins/flot/jquery.flot.tooltip.min.js",
                      "~/Content/js/plugins/flot/jquery.flot.resize.js",
                      "~/Content/js/plugins/flot/jquery.flot.pie.js",
                      "~/Content/js/plugins/flot/jquery.flot.time.js",
                      "~/Content/js/plugins/flot/jquery.flot.spline.js"));

            // Peity
            bundles.Add(new ScriptBundle("~/plugins/peity").Include(
                      "~/Content/js/plugins/peity/jquery.peity.min.js",
                      "~/Content/js/demo/peity-demo.js"));

            // GITTER
            bundles.Add(new ScriptBundle("~/bundles/gritter").Include(
                        "~/Content/js/plugins/gritter/jquery.gritter.min.js"));
            // Sparkline
            bundles.Add(new ScriptBundle("~/plugins/sparkline").Include(
                      "~/Content/js/plugins/sparkline/jquery.sparkline.min.js"));
            // Sparkline demo data
            bundles.Add(new ScriptBundle("~/plugins/sparklinedemo").Include(
                      "~/Content/js/demo/sparkline-demo.js"));

            // ChartJS chart
            bundles.Add(new ScriptBundle("~/plugins/chartJs").Include(
                      "~/Content/js/plugins/chartJs/Chart.min.js"));

            // toastr notification 
            bundles.Add(new ScriptBundle("~/plugins/toastr").Include(
                      "~/Content/js/plugins/toastr/toastr.min.js"));

            // fullCalendar 
            bundles.Add(new ScriptBundle("~/plugins/fullCalendar").Include(
                      "~/Scripts/plugins/fullcalendar/fullcalendar.min.js"));

            //clockpicker plugins
            bundles.Add(new ScriptBundle("~/plugins/clockpicker").Include(
               "~/Content/js/plugins/clockpicker/clockpicker.js"));

            //daterangepicker-bs3
            bundles.Add(new StyleBundle("~/Content/daterangepicker-bs3").Include(
               "~/Content/css/plugins/daterangepicker/daterangepicker-bs3.css"));

            //IonRangeSlider
            bundles.Add(new ScriptBundle("~/plugins/ionRangeSlider").Include(
               "~/Content/js/plugins/ionRangeSlider/ion.rangeSlider.min.js"));

            // knob
            bundles.Add(new ScriptBundle("~/plugins/knob").Include(
                 "~/Content/js/plugins/jsKnob/jquery.knob.js"));



            //Datepicker bootstrap
            bundles.Add(new ScriptBundle("~/plugins/datepickerbootstrap").Include(
         "~/Content/js/plugins/datapicker/bootstrap-datepicker.js"));

            ////HijriDatepicker bootstrap
            //bundles.Add(new ScriptBundle("~/plugins/hijridatepickerbootstrap").Include(
            //"~/Content/js/plugins/hijriDatepicker/bootstrap-hijri-datetimepicker.min.js"));

            //Datepicker bootstrap
            bundles.Add(new ScriptBundle("~/plugins/datepicker").Include(
            "~/Content/js/plugins/daterangepicker/daterangepicker.js"));

            //select2 full
            bundles.Add(new ScriptBundle("~/plugins/select2full").Include(
            "~/Content/js/plugins/select2/select2.full.min.js"));

            //touchspin
            bundles.Add(new ScriptBundle("~/plugins/touchspin").Include(
               "~/Content/js/plugins/touchspin/jquery.bootstrap-touchspin.min.js"));

            //bootstrap-touchspin
            bundles.Add(new ScriptBundle("~/plugins/bootstrap-touchspin").Include(
               "~/Content/js/plugins/bootstrap-tagsinput/bootstrap-tagsinput.js"));

            //cropper
            bundles.Add(new ScriptBundle("~/plugins/cropper").Include(
            "~/Content/js/plugins/cropper/cropper.min.js"));

            //Dual Listbox
            bundles.Add(new ScriptBundle("~/plugins/Listbox").Include(
               "~/Content/js/plugins/dualListbox/jquery.bootstrap-duallistbox.js"));

            //nouislider
            bundles.Add(new ScriptBundle("~/plugins/nouislider").Include(
            "~/Content/js/plugins/nouslider/jquery.nouislider.min.js"));

            //Switchery
            bundles.Add(new ScriptBundle("~/plugins/Switchery").Include(
           "~/Content/js/plugins/switchery/switchery.js"));

            //bootstrap-colorpicker
            bundles.Add(new ScriptBundle("~/plugins/bootstrap-colorpicker").Include(
              "~/Content/js/plugins/colorpicker/bootstrap-colorpicker.min.js"));

            //moment
            bundles.Add(new ScriptBundle("~/plugins/moment").Include(
              "~/Content/js/plugins/fullcalendar/moment.min.js"));
            //jstree
            bundles.Add(new ScriptBundle("~/plugins/jstree").Include(
              "~/Content/js/plugins/jsTree/jstree.min.js"));

            //bootstrap-markdown
            bundles.Add(new ScriptBundle("~/plugins/bootstrap-markdown").Include(
              "~/Content/js/plugins/bootstrap-markdown/bootstrap-markdown.js"));

            //footer
            bundles.Add(new ScriptBundle("~/plugins/footer").Include(
                 "~/Content/js/plugins/footable/footable.all.min.js"));

            //Touch Punch - Touch Event Support for jQuery UI
            bundles.Add(new ScriptBundle("~/plugins/touch-punch").Include(
                     "~/Content/js/plugins/touchpunch/jquery.ui.touch-punch.min.js"));

            //unobtrusive-ajax
            bundles.Add(new ScriptBundle("~/js/unobtrusive-ajax").Include(
                "~/Content/js/jquery.unobtrusive-ajax.min.js"));

            //footable
            bundles.Add(new ScriptBundle("~/js/plugins/footable").Include(
                "~/Content/js/plugins/footable/footable.all.min.js"));


            //Rich Text Editor
            bundles.Add(new ScriptBundle("~/Content/smart_theme/dist/Editor").Include(
           "~/Content/smart_theme/dist/Editor/summernote.js"));

            //sweetalert
            bundles.Add(new ScriptBundle("~/js/plugins/sweetalert").Include(
                "~/Content/js/plugins/sweetalert/sweetalert.min.js"));

            //sweetalert2
            bundles.Add(new ScriptBundle("~/js/plugins/sweetalert2").Include(
                "~/Content/smart_theme/dist/js/notifications/sweetalert2/sweetalert2@11.js"));

            //pwstrength
            bundles.Add(new ScriptBundle("~/js/plugins/pwstrength").Include(
                "~/Content/js/plugins/pwstrength/pwstrength-bootstrap.min.js",
                "~/Content/js/plugins/pwstrength/zxcvbn.js"));

            //validate
            bundles.Add(new ScriptBundle("~/js/plugins/validate").Include(
                          "~/Content/js/plugins/validate/jquery.validate.min.js"));

            //jasny
            bundles.Add(new StyleBundle("~/plugins/jasny").Include(
              "~/Content/js/plugins/jasny/jasny-bootstrap.min.js"));

            //DROPZONE
            bundles.Add(new StyleBundle("~/plugins/dropzone").Include(
                     "~/Content/js/plugins/dropzone/dropzone.js"));

            //CodeMirror
            bundles.Add(new StyleBundle("~/plugins/codemirror").Include(
              "~/Content/js/plugins/codemirror/codemirror.js"));
            bundles.Add(new StyleBundle("~/plugins/xml").Include(
            "~/Content/js/plugins/codemirror/mode/xml/xml.js"));


            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Content/js/jquery.validate.js",
                        "~/Content/js/jquery.validate.unobtrusive.js"));

            bundles.Add(new ScriptBundle("~/bundles/filepond").Include(
                       "~/Content/smart_theme/dist/smart_uploader/filepond-plugin-file-validate-size.js",
                        "~/Content/smart_theme/dist/smart_uploader/filepond-plugin-file-validate-type.js",
                        "~/Content/smart_theme/dist/smart_uploader/filepond-plugin-image-preview.js",
                        "~/Content/smart_theme/dist/smart_uploader/filepond-plugin-pdf-preview.js",
                        "~/Content/smart_theme/dist/smart_uploader/filepond-plugin-file-encode.js",
                        "~/Content/smart_theme/dist/smart_uploader/filepond-plugin-image-overlay.js",
                        "~/Content/smart_theme/dist/smart_uploader/filepond-plugin-media-preview.js",
                        "~/Content/smart_theme/dist/smart_uploader/filepond-plugin-file-metadata.js",
                        "~/Content/smart_theme/dist/smart_uploader/filepond-plugin-file-poster.min.js",
                        "~/Content/smart_theme/dist/smart_uploader/filepond.js"
                        ));

        }
    }
}
