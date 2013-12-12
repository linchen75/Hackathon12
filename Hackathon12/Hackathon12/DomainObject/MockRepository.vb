Imports Hackathon12.DomainObject

Namespace DB

    Public Class CompanyRepository
        Implements IRepository(Of Company)

        Private Shared _companies As New List(Of Company)
        Private Shared _position As Integer

        Private Sub New()
            _companies.Add(New Company(1, "太平保险 Taiping", "太平共享金融服务（上海）有限公司暨中国太平保险集团共享服务中心（以下简称""共享服务中心""）隶属于中国保险行业第一家跨国综合保险金融集团——中国太平保险集团，现有员工1500余人，是一家专业从事金融保险服务的创新型企业。中国太平保险集团（以下简称""中国太平""），是隶属于国务院的国有金融保险集团，原名中国保险（控股）有限公司，2009年6月启用""中国太平""新名。经营区域遍及中国内地、港澳、欧洲、大洋洲、东亚及东南亚等地区。", "http://china.icbdr.com/images/CN/TN/logo-taiping.png"))
            _companies.Add(New Company(2, "森马 Semir", "我们始终秉承""利他共赢""的企业核心价值观和""小河有水大河满""的经营哲学，强调与合作伙伴等利益相关方的共赢，追求企业与员工、企业与社会之间的和谐发展。成就员工梦想，创造社会价值！在未来发展中，我们将以共赢为基石，借力资本市场，继续实施多品牌发展战略，将森马发展成为满足儿童及成人专业、时尚、多样生活需求的多品牌服饰集团，实现""森马伴你一生""的企业理想。加入我们一起实现梦想，成就事业吧！", "http://china.icbdr.com/images/CN/TN/logo-semir.png"))
            _companies.Add(New Company(3, "创维 Skyworth", "岁月如潮，二十年奔涌而来，漫过心堤，打湿一部创维史书。一路风雨，一路迷茫，一路辉煌。他们是怎样沿着岁月的阶梯盘桓而上，抵至理想的境地？他们是怎样在惨烈的市场竞争中激流勇进，达到胜利的彼岸？他们是怎样无怨无悔地保持了一颗平常心，雕刻精彩的生活？抚摸那些意蕴丰满的心灵，总感叹生命的千姿百态。在茫茫人海中，我们寻找着恢弘的自我，寻找着让生命璀璨夺目的机缘。而他们，也许已经有了答案。他们是营销战线的将士、研发岗位的精英，制造行业的实干家……以他们的成长历程为蓝本，写意人生，追寻拼搏意境，展示生命的斑斓与瑰丽，也寄希望于他们在回放的记忆中，使读者啜饮营养，更希冀他们不断超越自我，因为每一个站在旧的纪录上起跑的人，都是胜利者！", "http://china.icbdr.com/images/CN/TN/logo-skyworth.png"))
            _companies.Add(New Company(4, "嘉银财富 Jiayincaifu", "你我贷网络借贷平台，隶属于上海嘉银金融信息服务有限公司，是集网络借贷、投资理财、互动交流等多功能于一体的创新型P2P网络借贷平台。公司于2011年6月经上海市工商行政管理局批准正式注册成立，注册资本1000万元人民币，总部位于上海市浦东新区向城路58号上海东方国际科技大厦8楼。历经两年的探索和发展，你我贷平台目前已成为全国微金融行业具有较强实力和市场影响力的P2P网络借贷平台，是上海市P2P网络借贷平台创新试点企业之一。并于2012年7月份获得由上海市政府亲自下批颁发的""金融信息服务""资质牌照。在过往两年间，相继获得中国小额信贷联盟会员单位、中国小额信贷机构联席会会员单位、上海市信息服务行业协会会员单位、上海市信用服务行业协会会员单位、理财周刊颁发的""最受欢迎理财服务奖""等众多荣誉。", "http://china.icbdr.com/images/CN/TN/logo-jiayin.png"))
            _companies.Add(New Company(5, "联想 Lenovo", "在联想，我们员工都有一个共同的愿望，就是成为最出色的企业。无论是在服务顾客，团队合作，还是在社区贡献方面，我们都在努力打造一家独特的公司，要通过具有丰富多彩的文化和经验丰富的员工创造和交付无与伦比的产品。我们的实力就在于这种多元性。每天在每个项目中，我们都在创建一种用于互相包容和尊重他人的崭新语言。我们致力于营造一个提倡创业精神和主人翁态度的环境。一个能够充分发挥人们的才干，并表彰和奖励先进的工作场所。请来参加我们的""人才网络""，探求各种机会。", "http://china.icbdr.com/mediamanagement/mz/mr08bw71j032484sxmz.jpg"))
            _companies.Add(New Company(6, "IHG", "我们的愿景是打造宾客挚爱的杰出酒店，成为世界上最好的公司之一。从全球大都市和渡假胜地的豪华酒店到家庭式旅馆，我们拥有九大优质品牌。所有品牌都各具特色，给顾客提供始终如一、温馨贴心、别具一格和值得信赖的品牌酒店体验。我们的品牌体现了我们对顾客的承诺，而赋予这些品牌生命力的正是我们富有才干和充满热情的员工。我们深谙待客之道。我们提供的工作机会和培训吸引了最出色的酒店管理和营销人才，并为明天的全球酒店业培养更优秀的员工技能。我们企业文化的核心是人人以负责任的态度为工作尽心竭力。", "http://china.icbdr.com/images/CN/TN/logo-ihg.png"))
            _companies.Add(New Company(7, "TCL", "TCL集团股份有限公司是中国最大的、全球性规模经营的消费类电子企业集团之一，旗下拥有四家上市公司：TCL集团（SZ.000100）、TCL多媒体科技（01070 .HK）、TCL通讯科技（02618. HK）、通力电子（01249. HK）。目前，TCL已形成多媒体、通讯、华星光电和TCL家电四大产业集团，以及系统科技事业本部、泰科立集团、新兴业务群、投资业务群、翰林汇公司、房地产六大业务板块。", "http://china.icbdr.com/images/CN/TN/logo-tcl.png"))
            _companies.Add(New Company(8, "宁波 Ningbo", "为持续推进宁波市海外高层人才引进工作，切实加大""3315计划""实施力度，宁波将于2013年5月在美国纽约和硅谷举办""2013年浙江民营资 本与海外人才智力对接活动""，真诚欢迎您来参加此次现场招聘活动。 ", "http://china.icbdr.com/images/cn/spot/cnfeatemp/alogo.jpg"))

            _position = 9
        End Sub

        Function GetAll() As List(Of Company) Implements IRepository(Of Company).GetAll
            Return _companies
        End Function

        Function Add(ByVal oCompany As Company) As Boolean Implements IRepository(Of Company).Add
            _companies.Add(oCompany)
            _position += 1
            Return True
        End Function
    End Class

End Namespace
