<!DOCTYPE html>
<html>
<head>
  <meta charset="utf-8">
  
  <title>ASP.NET Core MVC Select Tag Helper | Dave Paquette</title>
  <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
  <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1">
  <meta name="description" content="In this post from my series exploring the ASP.NET Core MVC tag helpers, I will be covering the select tag helper.
The select tag helper is used to generated select and associated option elements for p">
<meta property="og:type" content="article">
<meta property="og:title" content="ASP.NET Core MVC Select Tag Helper">
<meta property="og:url" content="http://www.davepaquette.com/archive/2015/05/18/mvc6-select-tag-helper.aspx">
<meta property="og:site_name" content="Dave Paquette">
<meta property="og:description" content="In this post from my series exploring the ASP.NET Core MVC tag helpers, I will be covering the select tag helper.
The select tag helper is used to generated select and associated option elements for p">
<meta property="og:updated_time" content="2017-11-29T03:21:21.663Z">
<meta name="twitter:card" content="summary">
<meta name="twitter:title" content="ASP.NET Core MVC Select Tag Helper">
<meta name="twitter:description" content="In this post from my series exploring the ASP.NET Core MVC tag helpers, I will be covering the select tag helper.
The select tag helper is used to generated select and associated option elements for p">
  
  
    <link rel="icon" href="/css/images/favicon-32x32.png">
  
    
  <link href="/css/style.css?v=1241safds" rel="stylesheet" type="text/css">
  
<!-- Google Analytics -->
<script type="text/javascript">
(function(i,s,o,g,r,a,m){i['GoogleAnalyticsObject']=r;i[r]=i[r]||function(){
(i[r].q=i[r].q||[]).push(arguments)},i[r].l=1*new Date();a=s.createElement(o),
m=s.getElementsByTagName(o)[0];a.async=1;a.src=g;m.parentNode.insertBefore(a,m)
})(window,document,'script','//www.google-analytics.com/analytics.js','ga');

ga('create', 'UA-37617956-1', 'auto');
ga('send', 'pageview');

</script>
<!-- End Google Analytics -->


  

  
</head>
<body>
  <div id="container">
    <header id="header">
  <div id="header-main" class="header-inner">
    <div class="outer">
      <a href="/" id="logo"><i class="logo" style="background-image: url(/css/images/profile_small.jpg)"></i><span class="site-title">Dave Paquette</span></a>
      <nav id="main-nav">
        
          <a class="main-nav-link" href="/.">Home</a>
        
          <a class="main-nav-link" href="/archives">Archives</a>
        
          <a class="main-nav-link" href="/projects.html">Projects</a>
        
          <a class="main-nav-link" href="/speaking.html">Speaking</a>
        
          <a class="main-nav-link" href="/about.html">About</a>
        
          <a class="main-nav-link main-nav-link-highlight" href="https://davepaquette.com/hireme">Hire Me</a>
      </nav>
      
        <nav id="sub-nav">
          <div class="profile" id="profile-nav">
            <a id="profile-anchor" href="javascript:;"><img class="avatar" src="/css/images/coffee.png"><i class="fa fa-caret-down"></i></a>
          </div>
        </nav>
      
      <div id="search-form-wrap">
        <form action="//google.com/search" method="get" accept-charset="UTF-8" class="search-form"><input type="search" name="q" results="0" class="search-form-input" placeholder="Search"><button type="submit" class="search-form-submit"> </button><input type="hidden" name="sitesearch" value="http://www.davepaquette.com"></form>
      </div>
    </div>
  </div>
  <div id="main-nav-mobile" class="header-sub header-inner">
    <table class="menu outer">
      <tr>
        
          <td><a class="main-nav-link" href="/.">Home</a></td>
        
          <td><a class="main-nav-link" href="/archives">Archives</a></td>
        
          <td><a class="main-nav-link" href="/projects.html">Projects</a></td>
        
          <td><a class="main-nav-link" href="/speaking.html">Speaking</a></td>
        
          <td><a class="main-nav-link" href="/about.html">About</a></td>
        
        <td>
          <form action="//google.com/search" method="get" accept-charset="UTF-8" class="search-form"><input type="search" name="q" results="0" class="search-form-input" placeholder="Search"><input type="hidden" name="sitesearch" value="http://www.davepaquette.com"></form>
        </td>
      </tr>
    </table>
  </div>
</header>

    <div id="sponsor-banner">&nbsp;</div>
    <div class="outer">
      
        <aside id="profile">
  <div class="inner profile-inner">
    <div class="base-info profile-block">
      <img id="avatar" src="/css/images/coffee.png">
      <h2 id="name">Dave Paquette</h2>
      <h3 id="title">Caffeine Driven Development</h3>
      <span id="location"><i class="fa fa-map-marker"></i>Canada</span>
      <a id="follow" href="https://github.com/dpaquette/">FOLLOW</a>
    </div>
    <div class="article-info profile-block">
      <div class="article-info-block">
        98
        <span>posts</span>
      </div>
      <div class="article-info-block">
        39
        <span>tags</span>
      </div>
    </div>
    
    <div class="contact-info profile-block">
      <table class="contact-list">
        <tr>
          
          <td><a href="http://github.com/dpaquette" target="_blank" title="github"><i class="fa fa-github"></i></a></td>
          
          <td><a href="https://twitter.com/Dave_Paquette" target="_blank" title="twitter"><i class="fa fa-twitter"></i></a></td>
          
          <td><a href="/atom.xml" target="_blank" title="rss"><i class="fa fa-rss"></i></a></td>
          
        </tr>
      </table>
    </div>
    
    
  </div>
  <div class="additional-sidebar">
  <br/>
  <a href="https://www.paypal.me/davepaquette/3.5usd"><img src="//www.davepaquette.com/wp-content/uploads/2015/11/buy-me-coffee.png" alt="Buy me a cofffe!"/></a>
  
    
  <div class="widget-wrap">
    <h3 class="widget-title">recent posts</h3>
    <div class="widget">
      <ul id="recent-post" class="">
        
          <li>
            
            <div class="item-thumbnail">
              <a href="/archive/2017/11/28/authorize-resource-tag-helper.aspx" class="thumbnail">
  
    <span class="thumbnail-image thumbnail-none"></span>
  
</a>
            </div>
            
            <div class="item-inner">
              <p class="item-category"><a class="article-category-link" href="/categories/ASP-NET-Core/">ASP.NET Core</a><i class="fa fa-angle-right"></i><a class="article-category-link" href="/categories/ASP-NET-Core/Tag-Helpers/">Tag Helpers</a></p>
              <p class="item-title"><a href="/archive/2017/11/28/authorize-resource-tag-helper.aspx" class="title">Authorize Resource Tag Helper for ASP.NET Core</a></p>
              <p class="item-date"><time datetime="2017-11-29T01:30:00.000Z" itemprop="datePublished">2017-11-28</time></p>
            </div>
          </li>
        
          <li>
            
            <div class="item-thumbnail">
              <a href="/archive/2017/11/05/authorize-tag-helper.aspx" class="thumbnail">
  
    <span class="thumbnail-image thumbnail-none"></span>
  
</a>
            </div>
            
            <div class="item-inner">
              <p class="item-category"><a class="article-category-link" href="/categories/ASP-NET-Core/">ASP.NET Core</a><i class="fa fa-angle-right"></i><a class="article-category-link" href="/categories/ASP-NET-Core/Tag-Helpers/">Tag Helpers</a></p>
              <p class="item-title"><a href="/archive/2017/11/05/authorize-tag-helper.aspx" class="title">Authorize Tag Helper for ASP.NET Core</a></p>
              <p class="item-date"><time datetime="2017-11-05T19:38:30.000Z" itemprop="datePublished">2017-11-05</time></p>
            </div>
          </li>
        
          <li>
            
            <div class="item-thumbnail">
              <a href="/archive/2016/11/27/integration-testing-with-entity-framework-core-and-sql-server.aspx" class="thumbnail">
  
    <span class="thumbnail-image thumbnail-none"></span>
  
</a>
            </div>
            
            <div class="item-inner">
              <p class="item-category"><a class="article-category-link" href="/categories/Entity-Framework-Core/">Entity Framework Core</a></p>
              <p class="item-title"><a href="/archive/2016/11/27/integration-testing-with-entity-framework-core-and-sql-server.aspx" class="title">Integration Testing with Entity Framework Core and SQL Server</a></p>
              <p class="item-date"><time datetime="2016-11-27T22:00:00.000Z" itemprop="datePublished">2016-11-27</time></p>
            </div>
          </li>
        
          <li>
            
            <div class="item-thumbnail">
              <a href="/archive/2016/11/22/creating-a-new-view-engine-in-asp-net-core.aspx" class="thumbnail">
  
    <span style="background-image:url(https://www.davepaquette.com/images/pugzor.png
)" alt="Creating a New View Engine in ASP.NET Core" class="thumbnail-image"></span>
  
</a>
            </div>
            
            <div class="item-inner">
              <p class="item-category"><a class="article-category-link" href="/categories/ASP-NET-Core/">ASP.NET Core</a></p>
              <p class="item-title"><a href="/archive/2016/11/22/creating-a-new-view-engine-in-asp-net-core.aspx" class="title">Creating a New View Engine in ASP.NET Core</a></p>
              <p class="item-date"><time datetime="2016-11-22T17:00:00.000Z" itemprop="datePublished">2016-11-22</time></p>
            </div>
          </li>
        
          <li>
            
            <div class="item-thumbnail">
              <a href="/archive/2016/07/16/loading-view-components-from-a-class-library-in-asp-net-core.aspx" class="thumbnail">
  
    <span style="background-image:url(https://www.davepaquette.com/images/external_view_components/create_new_class_library.png
)" alt="Loading View Components from a Class Library in ASP.NET Core MVC" class="thumbnail-image"></span>
  
</a>
            </div>
            
            <div class="item-inner">
              <p class="item-category"><a class="article-category-link" href="/categories/ASP-NET-Core/">ASP.NET Core</a><i class="fa fa-angle-right"></i><a class="article-category-link" href="/categories/ASP-NET-Core/View-Components/">View Components</a></p>
              <p class="item-title"><a href="/archive/2016/07/16/loading-view-components-from-a-class-library-in-asp-net-core.aspx" class="title">Loading View Components from a Class Library in ASP.NET Core MVC</a></p>
              <p class="item-date"><time datetime="2016-07-16T12:36:36.000Z" itemprop="datePublished">2016-07-16</time></p>
            </div>
          </li>
        
      </ul>
    </div>
  </div>

  
  </div>
</aside>

      
      <section id="main">
      <article id="post-mvc6-select-tag-helper" class="article article-type-post" itemscope itemprop="blogPost">
  <div class="article-inner">
    
    
    
      <header class="article-header">
        
  
    <h1 class="article-title" itemprop="name">
      ASP.NET Core MVC Select Tag Helper
    </h1>
  

        <div class="article-meta">
          
  <div class="article-date">
    <i class="fa fa-calendar"></i>
    <a href="/archive/2015/05/18/mvc6-select-tag-helper.aspx">
      <time datetime="2015-05-18T11:00:00.000Z" itemprop="datePublished">2015-05-18</time>
    </a>
  </div>


          
  <div class="article-category">
  	<i class="fa fa-folder"></i>
    <a class="article-category-link" href="/categories/ASP-NET-Core/">ASP.NET Core</a><i class="fa fa-angle-right"></i><a class="article-category-link" href="/categories/ASP-NET-Core/Tag-Helpers/">Tag Helpers</a>
  </div>

        </div>
      </header>
    
    <div class="article-entry" itemprop="articleBody">
      
                
        <p>In this post from my series exploring the ASP.NET Core MVC tag helpers, I will be covering the select tag helper.</p>
<p>The select tag helper is used to generated select and associated option elements for properties of your models. This is an alternative to the _Html.DropDownListFor _HTML helper method.</p>
<h2 id="Select_Tag_Helper">Select Tag Helper</h2><p>The select tag helper is used by adding the <em>asp-for</em> attribute to a select element. For example consider a simple view model class containing a CountryCode property:<br><figure class="highlight csharp"><table><tr><td class="code"><pre><span class="line"><span class="keyword">public</span> <span class="keyword">class</span> <span class="title">SimpleViewModel</span></span><br><span class="line">&#123;</span><br><span class="line">    <span class="keyword">public</span> <span class="keyword">string</span> CountryCode &#123; <span class="keyword">get</span>; <span class="keyword">set</span>; &#125;</span><br><span class="line">&#125;</span><br></pre></td></tr></table></figure></p>
<p>You can bind a select element to the CountryCode property as follows:<br><figure class="highlight html"><table><tr><td class="code"><pre><span class="line"><span class="tag">&lt;<span class="title">select</span> <span class="attribute">asp-for</span>=<span class="value">"CountryCode"</span>&gt;</span><span class="tag">&lt;/<span class="title">select</span>&gt;</span></span><br></pre></td></tr></table></figure></p>
<p>…which would generate the following HTML:<br><figure class="highlight html"><table><tr><td class="code"><pre><span class="line"><span class="tag">&lt;<span class="title">select</span> <span class="attribute">name</span>=<span class="value">"CountryCode"</span> </span><br><span class="line">           <span class="attribute">id</span>=<span class="value">"CountryCode"</span>&gt;</span></span><br><span class="line"><span class="tag">&lt;/<span class="title">select</span>&gt;</span></span><br></pre></td></tr></table></figure></p>
<p>Now this is not overly useful because it is an empty drowdown list. You will probably want to add some options to your select.</p>
<h3 id="Adding_options">Adding options</h3><p>There are a couple ways you can add options to the select. You can simply add options directly in the markup:<br><figure class="highlight html"><table><tr><td class="code"><pre><span class="line"><span class="tag">&lt;<span class="title">select</span> <span class="attribute">asp-for</span>=<span class="value">"CountryCode"</span>&gt;</span></span><br><span class="line">    <span class="tag">&lt;<span class="title">option</span> <span class="attribute">value</span>=<span class="value">"CA"</span>&gt;</span>Canada<span class="tag">&lt;/<span class="title">option</span>&gt;</span></span><br><span class="line">    <span class="tag">&lt;<span class="title">option</span> <span class="attribute">value</span>=<span class="value">"US"</span>&gt;</span>US<span class="tag">&lt;/<span class="title">option</span>&gt;</span></span><br><span class="line">    <span class="tag">&lt;<span class="title">option</span> <span class="attribute">value</span>=<span class="value">"--"</span>&gt;</span>Other<span class="tag">&lt;/<span class="title">option</span>&gt;</span></span><br><span class="line"><span class="tag">&lt;/<span class="title">select</span>&gt;</span></span><br></pre></td></tr></table></figure></p>
<p>In this case, the options specified in markup will be included in the generated HTML. The selected option will automatically be determined based on the value of the model property. For example, if the CountryCode property is set to ‘CA’ in the model, then the following HTML would be generated:<br><figure class="highlight html"><table><tr><td class="code"><pre><span class="line"><span class="tag">&lt;<span class="title">select</span> <span class="attribute">name</span>=<span class="value">"CountryCode"</span> <span class="attribute">id</span>=<span class="value">"CountryCode"</span>&gt;</span></span><br><span class="line">    <span class="tag">&lt;<span class="title">option</span> <span class="attribute">selected</span>=<span class="value">"selected"</span> <span class="attribute">value</span>=<span class="value">"CA"</span>&gt;</span>Canada<span class="tag">&lt;/<span class="title">option</span>&gt;</span></span><br><span class="line">    <span class="tag">&lt;<span class="title">option</span> <span class="attribute">value</span>=<span class="value">"US"</span>&gt;</span>US<span class="tag">&lt;/<span class="title">option</span>&gt;</span></span><br><span class="line">    <span class="tag">&lt;<span class="title">option</span> <span class="attribute">value</span>=<span class="value">"--"</span>&gt;</span>Other<span class="tag">&lt;/<span class="title">option</span>&gt;</span></span><br><span class="line"><span class="tag">&lt;/<span class="title">select</span>&gt;</span></span><br></pre></td></tr></table></figure></p>
<p>If the list of options is dynamically loaded from a data source, you can use the <em>asp-items</em> tag helper attribute. All you need to do is set the <em>asp-items</em> attribute to an <em>IEnumerable<selectlistitem></selectlistitem></em>. For example, if we had a list of countries available on the ViewBag, we could specify the select options as follows:<br><figure class="highlight html"><table><tr><td class="code"><pre><span class="line"><span class="tag">&lt;<span class="title">select</span> <span class="attribute">asp-for</span>=<span class="value">"CountryCode"</span> </span><br><span class="line">         <span class="attribute">asp-items</span>=<span class="value">"ViewBag.Countries"</span>&gt;</span></span><br><span class="line"><span class="tag">&lt;/<span class="title">select</span>&gt;</span></span><br></pre></td></tr></table></figure></p>
<p>This will generate a select with options for each of the SelectListItems in the Countries collection.</p>
<h3 id="Multiple_Select">Multiple Select</h3><p>The select tag helper will automatically generate a multi-select if the property specified in the <em>asp-for</em> attribute is an IEnumerable. For example, given the following model class:<br><figure class="highlight csharp"><table><tr><td class="code"><pre><span class="line"><span class="keyword">public</span> <span class="keyword">class</span> <span class="title">SimpleViewModel</span></span><br><span class="line">&#123;</span><br><span class="line">    <span class="keyword">public</span> IEnumerable&lt;<span class="keyword">string</span>&gt; CountryCodes &#123; <span class="keyword">get</span>; <span class="keyword">set</span>; &#125;</span><br><span class="line">&#125;</span><br></pre></td></tr></table></figure></p>
<p>Binding the <em>asp-for</em> attribute to the CountryCodes property as follows:<br><figure class="highlight html"><table><tr><td class="code"><pre><span class="line"><span class="tag">&lt;<span class="title">select</span> <span class="attribute">asp-for</span>=<span class="value">"CountryCodes"</span> </span><br><span class="line">        <span class="attribute">asp-items</span>=<span class="value">"ViewBag.Countries"</span>&gt;</span></span><br><span class="line"><span class="tag">&lt;/<span class="title">select</span>&gt;</span></span><br></pre></td></tr></table></figure></p>
<p>…would generate the following HTML:<br><figure class="highlight html"><table><tr><td class="code"><pre><span class="line"><span class="tag">&lt;<span class="title">select</span> <span class="attribute">name</span>=<span class="value">"CountryCodes"</span> </span><br><span class="line">        <span class="attribute">id</span>=<span class="value">"CountryCodes"</span> </span><br><span class="line">        <span class="attribute">multiple</span>=<span class="value">"multiple"</span>&gt;</span></span><br><span class="line">    <span class="tag">&lt;<span class="title">option</span> <span class="attribute">selected</span>=<span class="value">"selected"</span> </span><br><span class="line">            <span class="attribute">value</span>=<span class="value">"CA"</span>&gt;</span>Canada<span class="tag">&lt;/<span class="title">option</span>&gt;</span></span><br><span class="line">    <span class="tag">&lt;<span class="title">option</span> <span class="attribute">value</span>=<span class="value">"USA"</span>&gt;</span>United States<span class="tag">&lt;/<span class="title">option</span>&gt;</span></span><br><span class="line">    <span class="tag">&lt;<span class="title">option</span> <span class="attribute">value</span>=<span class="value">"--"</span>&gt;</span>Other<span class="tag">&lt;/<span class="title">option</span>&gt;</span></span><br><span class="line"><span class="tag">&lt;/<span class="title">select</span>&gt;</span></span><br></pre></td></tr></table></figure></p>
<h1 id="Conclusion">Conclusion</h1><p>That covers all the functionality provided by the select tag helper in ASP.NET Core MVC, which provides a clean syntax for generating select elements based on the values in your model. In the next post, I will cover the <a href="https://www.davepaquette.com/archive/2015/05/18/mvc-6-form-tag-helper.aspx">Form tag helper</a>.</p>

      
    </div>
    <footer class="article-footer">
      <a data-url="http://www.davepaquette.com/archive/2015/05/18/mvc6-select-tag-helper.aspx" data-id="cjakkg6go006dmopjbmjrgfwy" class="article-share-link">Share</a>
      
        <a href="http://www.davepaquette.com/archive/2015/05/18/mvc6-select-tag-helper.aspx#disqus_thread" class="article-comment-link">Comments</a>
      
      
  <ul class="article-tag-list"><li class="article-tag-list-item"><a class="article-tag-list-link" href="/tags/ASP-NET-Core/">ASP.NET Core</a></li><li class="article-tag-list-item"><a class="article-tag-list-link" href="/tags/MVC/">MVC</a></li><li class="article-tag-list-item"><a class="article-tag-list-link" href="/tags/Tag-Helpers/">Tag Helpers</a></li><li class="article-tag-list-item"><a class="article-tag-list-link" href="/tags/VS-2015/">VS 2015</a></li></ul>

    </footer>
  </div>
  
    
<nav id="article-nav">
  
    <a href="/archive/2015/05/18/mvc-6-form-tag-helper.aspx" id="article-nav-newer" class="article-nav-link-wrap">
      <strong class="article-nav-caption">Newer</strong>
      <div class="article-nav-title">
        
          ASP.NET Core MVC Form Tag Helper
        
      </div>
    </a>
  
  
    <a href="/archive/2015/05/18/mvc-6-label-tag-helper.aspx" id="article-nav-older" class="article-nav-link-wrap">
      <strong class="article-nav-caption">Older</strong>
      <div class="article-nav-title">ASP.NET Core MVC Label Tag Helper</div>
    </a>
  
</nav>


  
</article>


<section id="comments">
  <div id="disqus_thread">
    <noscript>Please enable JavaScript to view the <a href="//disqus.com/?ref_noscript">comments powered by Disqus.</a></noscript>
  </div>
</section>


      </section>
      
    </div>
    <footer id="footer">
  
  <div class="outer">
    <div id="footer-info" class="inner">
      &copy; 2009 - 2017 Dave Paquette<br>
      Powered by <a href="http://hexo.io/" target="_blank">Hexo</a>. Theme by <a href="http://github.com/ppoffice">PPOffice</a>
    </div>
  </div>
</footer>
    

<script>
  var disqus_shortname = 'davepaquette';
  (function(){
    var dsq = document.createElement('script');
    dsq.type = 'text/javascript';
    dsq.async = true;
    dsq.src = '//' + disqus_shortname + '.disqus.com/embed.js';
    (document.getElementsByTagName('head')[0] || document.getElementsByTagName('body')[0]).appendChild(dsq);
  })();
</script>



 <script src="https://ajax.googleapis.com/ajax/libs/jquery/2.1.3/jquery.min.js"></script>
 <script src="https://ajax.googleapis.com/ajax/libs/webfont/1.5.18/webfont.js"></script>


<script>
  WebFont.load({
    google: {
      families: ['Open Sans:400italic,400,600', 'Source Code Pro']
    }
  });
</script>

<link rel="stylesheet" href="/font-awesome/css/font-awesome.min.css" type="text/css">


  <link rel="stylesheet" href="/fancybox/jquery.fancybox.css" type="text/css">
  <script src="/fancybox/jquery.fancybox.pack.js" type="text/javascript"></script>


<script src="/js/script.js" type="text/javascript"></script>

    <script type="text/javascript">
      $(function() {

                    // min inclusive, max exclusive
            function getRandomInt(min, max) {
              min = Math.ceil(min);
              max = Math.floor(max);
              return Math.floor(Math.random() * (max - min)) + min;
            }

            var sponsorLinks = 
            [
              {
                header: "Pearson",
                text: "ASP.NET Core Application Development",
                url:"http://click.linksynergy.com/link?id=qigXCeNV4sI&offerid=145238.2497285&type=2&murl=http%3A%2F%2Fwww.informit.com%2Ftitle%2F9781509304066"
                
              },
              {
                header: "Amazon",
                text: "ASP.NET Core Application Development",
                url: "http://amzn.to/2h6J4IW"                 
              }            
            ];

            var sponsor = sponsorLinks[getRandomInt(0,sponsorLinks.length)];

            $("#sponsor-banner").html("<div class='outer'><strong>" + sponsor.header + ": </strong>" + "<a href='" + sponsor.url + "'>" + sponsor.text + "</a> <i class='fa fa-external-link'></i></div>");
      });
    </script>
  </div>
</body>
</html>