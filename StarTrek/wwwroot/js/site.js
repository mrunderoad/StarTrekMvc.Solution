// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(".timeline-wrapper .timeline-content-item > span").on("mouseenter mouseleave", function(e){
  $(".timeline-wrapper .timeline-content-item.active").removeClass("active");
  $(this).parent().addClass("active");
});