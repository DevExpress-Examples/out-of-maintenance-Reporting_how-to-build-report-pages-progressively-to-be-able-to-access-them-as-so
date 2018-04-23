# How to build report pages progressively to be able to access them as soon as they are created, and forcibly interrupt report building


<p>The following example demonstrates how to generate report pages in the background, so that ready pages are displayed in the <strong>PrintControl</strong>, and the progress bar shows the current state of report building. To do this, it is necessary to call the <strong>XtraReport.CreateDocument</strong> method with a parameter set to <strong>true</strong>.<br><br>Regardless of this parameter setting, a document will not be produced in a background thread. Document creation is not asynchronous, as parts of a document are rendered each time the <strong>System.Windows.Forms.Application.Idle</strong> event is raised (in the WPF environment, a document is created using ticks from the <strong>System.Windows.Threading.DispatcherTimer</strong> class).</p>
<p>To stop generating a report, call the <strong>XtraReport.StopPageBuilding</strong> method.</p>
<p>See also: <a href="https://www.devexpress.com/Support/Center/p/E548">How to silently pass a parameter's value to a report</a>.</p>

<br/>


