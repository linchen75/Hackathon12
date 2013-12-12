<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="MyAssistant.aspx.vb" MasterPageFile="~/Site.Master" Inherits="Hackathon12.MyAssistant" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
  <div id="main">
    <div id="companyList">
      <div class="companyRow">
        <h3 class="companyName">太平保险</h3>
          招聘进度： <div class="progress">
          <div class="progress-bar" role="progressbar" aria-valuenow="60" aria-valuemin="0" aria-valuemax="100" style="width: 60%;">
            <span class="sr-only">60% Complete</span>
          </div>
        </div>

        <div class="companyDescription">太平共享金融服务（上海）有限公司暨中国太平保险集团共享服务中心（以下简称""共享服务中心""）隶属于中国保险行业第一家跨国综合保险金融集团——中国太平保险集团，现有员工1500余人，是一家专业从事金融保险服务的创新型企业。中国太平保险集团（以下简称""中国太平""），是隶属于国务院的国有金融保险集团，原名中国保险（控股）有限公司，2009年6月启用""中国太平""新名。经营区域遍及中国内地、港澳、欧洲、大洋洲、东亚及东南亚等地区。</div>
        <div class="clearfix">
        <div class="btn-group">
            <button type="button" class="btn btn-info dropdown-toggle" data-toggle="dropdown">待投递<span class="caret"></span></button>
            <ul class="dropdown-menu" role="menu">
              <li><a href="#">Action</a></li>
              <li><a href="#">Another action</a></li>
              <li><a href="#">Something else here</a></li>
              <li class="divider"></li>
              <li><a href="#">Separated link</a></li>
            </ul>
          </div>
          <div class="comments">太平共享金融服务（上海）有限公司暨中国太平保险集团共享服务中心（以下简称""共享服务中心""）隶属于中国保险行业第一家跨国综合保险金融集团——中国太平保险集团，现有员工1500余人，是一家专业从事金融保险服务的创新型企业。中国太平保险集团（以下简称""中国太平""），是隶属于国务院的国有金融保险集团，原名中国保险（控股）有限公司，2009年6月启用""中国太平""新名。经营区域遍及中国内地、港澳、欧洲、大洋洲、东亚及东南亚等地区。</div>
         </div>

      </div>
      </div>
    </div>
  </div>

</asp:Content>