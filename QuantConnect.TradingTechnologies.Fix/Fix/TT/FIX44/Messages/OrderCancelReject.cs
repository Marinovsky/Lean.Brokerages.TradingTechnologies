// This is a generated file.  Don't edit it directly!

using QuickFix;
using QuantConnect.Fix.TT.FIX44.Fields;
namespace QuantConnect.Fix.TT.FIX44
{
    namespace Messages
    {
        public class OrderCancelReject : Message
        {
            public const string MsgType = "9";

            public OrderCancelReject() : base()
            {
                this.Header.SetField(new MsgType("9"));
            }

            public OrderCancelReject(
                    OrderID aOrderID,
                    OrdStatus aOrdStatus,
                    CxlRejResponseTo aCxlRejResponseTo
                ) : this()
            {
                this.OrderID = aOrderID;
                this.OrdStatus = aOrdStatus;
                this.CxlRejResponseTo = aCxlRejResponseTo;
            }

            public OrderID OrderID
            { 
                get 
                {
                    OrderID val = new OrderID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(OrderID val) 
            { 
                this.OrderID = val;
            }
            
            public OrderID Get(OrderID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(OrderID val) 
            { 
                return IsSetOrderID();
            }
            
            public bool IsSetOrderID() 
            { 
                return IsSetField(Fields.CustomTags.OrderID);
            }
            public SecondaryOrderID SecondaryOrderID
            { 
                get 
                {
                    SecondaryOrderID val = new SecondaryOrderID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(SecondaryOrderID val) 
            { 
                this.SecondaryOrderID = val;
            }
            
            public SecondaryOrderID Get(SecondaryOrderID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(SecondaryOrderID val) 
            { 
                return IsSetSecondaryOrderID();
            }
            
            public bool IsSetSecondaryOrderID() 
            { 
                return IsSetField(Fields.CustomTags.SecondaryOrderID);
            }
            public ClOrdID ClOrdID
            { 
                get 
                {
                    ClOrdID val = new ClOrdID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(ClOrdID val) 
            { 
                this.ClOrdID = val;
            }
            
            public ClOrdID Get(ClOrdID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(ClOrdID val) 
            { 
                return IsSetClOrdID();
            }
            
            public bool IsSetClOrdID() 
            { 
                return IsSetField(Fields.CustomTags.ClOrdID);
            }
            public TTClOrdID TTClOrdID
            { 
                get 
                {
                    TTClOrdID val = new TTClOrdID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(TTClOrdID val) 
            { 
                this.TTClOrdID = val;
            }
            
            public TTClOrdID Get(TTClOrdID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(TTClOrdID val) 
            { 
                return IsSetTTClOrdID();
            }
            
            public bool IsSetTTClOrdID() 
            { 
                return IsSetField(Fields.CustomTags.TTClOrdID);
            }
            public OrigClOrdID OrigClOrdID
            { 
                get 
                {
                    OrigClOrdID val = new OrigClOrdID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(OrigClOrdID val) 
            { 
                this.OrigClOrdID = val;
            }
            
            public OrigClOrdID Get(OrigClOrdID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(OrigClOrdID val) 
            { 
                return IsSetOrigClOrdID();
            }
            
            public bool IsSetOrigClOrdID() 
            { 
                return IsSetField(Fields.CustomTags.OrigClOrdID);
            }
            public OrdStatus OrdStatus
            { 
                get 
                {
                    OrdStatus val = new OrdStatus();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(OrdStatus val) 
            { 
                this.OrdStatus = val;
            }
            
            public OrdStatus Get(OrdStatus val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(OrdStatus val) 
            { 
                return IsSetOrdStatus();
            }
            
            public bool IsSetOrdStatus() 
            { 
                return IsSetField(Fields.CustomTags.OrdStatus);
            }
            public Account Account
            { 
                get 
                {
                    Account val = new Account();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(Account val) 
            { 
                this.Account = val;
            }
            
            public Account Get(Account val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(Account val) 
            { 
                return IsSetAccount();
            }
            
            public bool IsSetAccount() 
            { 
                return IsSetField(Fields.CustomTags.Account);
            }
            public TransactTime TransactTime
            { 
                get 
                {
                    TransactTime val = new TransactTime();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(TransactTime val) 
            { 
                this.TransactTime = val;
            }
            
            public TransactTime Get(TransactTime val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(TransactTime val) 
            { 
                return IsSetTransactTime();
            }
            
            public bool IsSetTransactTime() 
            { 
                return IsSetField(Fields.CustomTags.TransactTime);
            }
            public CxlRejResponseTo CxlRejResponseTo
            { 
                get 
                {
                    CxlRejResponseTo val = new CxlRejResponseTo();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(CxlRejResponseTo val) 
            { 
                this.CxlRejResponseTo = val;
            }
            
            public CxlRejResponseTo Get(CxlRejResponseTo val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(CxlRejResponseTo val) 
            { 
                return IsSetCxlRejResponseTo();
            }
            
            public bool IsSetCxlRejResponseTo() 
            { 
                return IsSetField(Fields.CustomTags.CxlRejResponseTo);
            }
            public CxlRejReason CxlRejReason
            { 
                get 
                {
                    CxlRejReason val = new CxlRejReason();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(CxlRejReason val) 
            { 
                this.CxlRejReason = val;
            }
            
            public CxlRejReason Get(CxlRejReason val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(CxlRejReason val) 
            { 
                return IsSetCxlRejReason();
            }
            
            public bool IsSetCxlRejReason() 
            { 
                return IsSetField(Fields.CustomTags.CxlRejReason);
            }
            public Text Text
            { 
                get 
                {
                    Text val = new Text();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(Text val) 
            { 
                this.Text = val;
            }
            
            public Text Get(Text val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(Text val) 
            { 
                return IsSetText();
            }
            
            public bool IsSetText() 
            { 
                return IsSetField(Fields.CustomTags.Text);
            }
            public TTID TTID
            { 
                get 
                {
                    TTID val = new TTID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(TTID val) 
            { 
                this.TTID = val;
            }
            
            public TTID Get(TTID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(TTID val) 
            { 
                return IsSetTTID();
            }
            
            public bool IsSetTTID() 
            { 
                return IsSetField(Fields.CustomTags.TTID);
            }
            public AOTCPreventionActionType AOTCPreventionActionType
            { 
                get 
                {
                    AOTCPreventionActionType val = new AOTCPreventionActionType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(AOTCPreventionActionType val) 
            { 
                this.AOTCPreventionActionType = val;
            }
            
            public AOTCPreventionActionType Get(AOTCPreventionActionType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(AOTCPreventionActionType val) 
            { 
                return IsSetAOTCPreventionActionType();
            }
            
            public bool IsSetAOTCPreventionActionType() 
            { 
                return IsSetField(Fields.CustomTags.AOTCPreventionActionType);
            }
            public BrokerID BrokerID
            { 
                get 
                {
                    BrokerID val = new BrokerID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(BrokerID val) 
            { 
                this.BrokerID = val;
            }
            
            public BrokerID Get(BrokerID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(BrokerID val) 
            { 
                return IsSetBrokerID();
            }
            
            public bool IsSetBrokerID() 
            { 
                return IsSetField(Fields.CustomTags.BrokerID);
            }
            public CompanyID CompanyID
            { 
                get 
                {
                    CompanyID val = new CompanyID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(CompanyID val) 
            { 
                this.CompanyID = val;
            }
            
            public CompanyID Get(CompanyID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(CompanyID val) 
            { 
                return IsSetCompanyID();
            }
            
            public bool IsSetCompanyID() 
            { 
                return IsSetField(Fields.CustomTags.CompanyID);
            }
            public HandlInst HandlInst
            { 
                get 
                {
                    HandlInst val = new HandlInst();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(HandlInst val) 
            { 
                this.HandlInst = val;
            }
            
            public HandlInst Get(HandlInst val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(HandlInst val) 
            { 
                return IsSetHandlInst();
            }
            
            public bool IsSetHandlInst() 
            { 
                return IsSetField(Fields.CustomTags.HandlInst);
            }
            public StagedOrderMsg StagedOrderMsg
            { 
                get 
                {
                    StagedOrderMsg val = new StagedOrderMsg();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(StagedOrderMsg val) 
            { 
                this.StagedOrderMsg = val;
            }
            
            public StagedOrderMsg Get(StagedOrderMsg val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(StagedOrderMsg val) 
            { 
                return IsSetStagedOrderMsg();
            }
            
            public bool IsSetStagedOrderMsg() 
            { 
                return IsSetField(Fields.CustomTags.StagedOrderMsg);
            }
            public StagedOrderOwner StagedOrderOwner
            { 
                get 
                {
                    StagedOrderOwner val = new StagedOrderOwner();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(StagedOrderOwner val) 
            { 
                this.StagedOrderOwner = val;
            }
            
            public StagedOrderOwner Get(StagedOrderOwner val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(StagedOrderOwner val) 
            { 
                return IsSetStagedOrderOwner();
            }
            
            public bool IsSetStagedOrderOwner() 
            { 
                return IsSetField(Fields.CustomTags.StagedOrderOwner);
            }
            public StagedOrderStatus StagedOrderStatus
            { 
                get 
                {
                    StagedOrderStatus val = new StagedOrderStatus();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(StagedOrderStatus val) 
            { 
                this.StagedOrderStatus = val;
            }
            
            public StagedOrderStatus Get(StagedOrderStatus val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(StagedOrderStatus val) 
            { 
                return IsSetStagedOrderStatus();
            }
            
            public bool IsSetStagedOrderStatus() 
            { 
                return IsSetField(Fields.CustomTags.StagedOrderStatus);
            }
            public ExternalSource ExternalSource
            { 
                get 
                {
                    ExternalSource val = new ExternalSource();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(ExternalSource val) 
            { 
                this.ExternalSource = val;
            }
            
            public ExternalSource Get(ExternalSource val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(ExternalSource val) 
            { 
                return IsSetExternalSource();
            }
            
            public bool IsSetExternalSource() 
            { 
                return IsSetField(Fields.CustomTags.ExternalSource);
            }
            public OrderIDGUID OrderIDGUID
            { 
                get 
                {
                    OrderIDGUID val = new OrderIDGUID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(OrderIDGUID val) 
            { 
                this.OrderIDGUID = val;
            }
            
            public OrderIDGUID Get(OrderIDGUID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(OrderIDGUID val) 
            { 
                return IsSetOrderIDGUID();
            }
            
            public bool IsSetOrderIDGUID() 
            { 
                return IsSetField(Fields.CustomTags.OrderIDGUID);
            }
            public ClearingAccountOverride ClearingAccountOverride
            { 
                get 
                {
                    ClearingAccountOverride val = new ClearingAccountOverride();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(ClearingAccountOverride val) 
            { 
                this.ClearingAccountOverride = val;
            }
            
            public ClearingAccountOverride Get(ClearingAccountOverride val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(ClearingAccountOverride val) 
            { 
                return IsSetClearingAccountOverride();
            }
            
            public bool IsSetClearingAccountOverride() 
            { 
                return IsSetField(Fields.CustomTags.ClearingAccountOverride);
            }
            public TextTT TextTT
            { 
                get 
                {
                    TextTT val = new TextTT();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(TextTT val) 
            { 
                this.TextTT = val;
            }
            
            public TextTT Get(TextTT val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(TextTT val) 
            { 
                return IsSetTextTT();
            }
            
            public bool IsSetTextTT() 
            { 
                return IsSetField(Fields.CustomTags.TextTT);
            }
            public TextA TextA
            { 
                get 
                {
                    TextA val = new TextA();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(TextA val) 
            { 
                this.TextA = val;
            }
            
            public TextA Get(TextA val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(TextA val) 
            { 
                return IsSetTextA();
            }
            
            public bool IsSetTextA() 
            { 
                return IsSetField(Fields.CustomTags.TextA);
            }
            public TextB TextB
            { 
                get 
                {
                    TextB val = new TextB();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(TextB val) 
            { 
                this.TextB = val;
            }
            
            public TextB Get(TextB val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(TextB val) 
            { 
                return IsSetTextB();
            }
            
            public bool IsSetTextB() 
            { 
                return IsSetField(Fields.CustomTags.TextB);
            }
            public TextC TextC
            { 
                get 
                {
                    TextC val = new TextC();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(TextC val) 
            { 
                this.TextC = val;
            }
            
            public TextC Get(TextC val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(TextC val) 
            { 
                return IsSetTextC();
            }
            
            public bool IsSetTextC() 
            { 
                return IsSetField(Fields.CustomTags.TextC);
            }
            public NoStrategyParameters NoStrategyParameters
            { 
                get 
                {
                    NoStrategyParameters val = new NoStrategyParameters();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(NoStrategyParameters val) 
            { 
                this.NoStrategyParameters = val;
            }
            
            public NoStrategyParameters Get(NoStrategyParameters val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(NoStrategyParameters val) 
            { 
                return IsSetNoStrategyParameters();
            }
            
            public bool IsSetNoStrategyParameters() 
            { 
                return IsSetField(Fields.CustomTags.NoStrategyParameters);
            }
            public TimeReceivedFromExchange TimeReceivedFromExchange
            { 
                get 
                {
                    TimeReceivedFromExchange val = new TimeReceivedFromExchange();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(TimeReceivedFromExchange val) 
            { 
                this.TimeReceivedFromExchange = val;
            }
            
            public TimeReceivedFromExchange Get(TimeReceivedFromExchange val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(TimeReceivedFromExchange val) 
            { 
                return IsSetTimeReceivedFromExchange();
            }
            
            public bool IsSetTimeReceivedFromExchange() 
            { 
                return IsSetField(Fields.CustomTags.TimeReceivedFromExchange);
            }
            public EchoDC_01 EchoDC_01
            { 
                get 
                {
                    EchoDC_01 val = new EchoDC_01();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(EchoDC_01 val) 
            { 
                this.EchoDC_01 = val;
            }
            
            public EchoDC_01 Get(EchoDC_01 val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(EchoDC_01 val) 
            { 
                return IsSetEchoDC_01();
            }
            
            public bool IsSetEchoDC_01() 
            { 
                return IsSetField(Fields.CustomTags.EchoDC_01);
            }
            public EchoDC_02 EchoDC_02
            { 
                get 
                {
                    EchoDC_02 val = new EchoDC_02();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(EchoDC_02 val) 
            { 
                this.EchoDC_02 = val;
            }
            
            public EchoDC_02 Get(EchoDC_02 val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(EchoDC_02 val) 
            { 
                return IsSetEchoDC_02();
            }
            
            public bool IsSetEchoDC_02() 
            { 
                return IsSetField(Fields.CustomTags.EchoDC_02);
            }
            public EchoDC_03 EchoDC_03
            { 
                get 
                {
                    EchoDC_03 val = new EchoDC_03();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(EchoDC_03 val) 
            { 
                this.EchoDC_03 = val;
            }
            
            public EchoDC_03 Get(EchoDC_03 val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(EchoDC_03 val) 
            { 
                return IsSetEchoDC_03();
            }
            
            public bool IsSetEchoDC_03() 
            { 
                return IsSetField(Fields.CustomTags.EchoDC_03);
            }
            public EchoDC_04 EchoDC_04
            { 
                get 
                {
                    EchoDC_04 val = new EchoDC_04();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(EchoDC_04 val) 
            { 
                this.EchoDC_04 = val;
            }
            
            public EchoDC_04 Get(EchoDC_04 val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(EchoDC_04 val) 
            { 
                return IsSetEchoDC_04();
            }
            
            public bool IsSetEchoDC_04() 
            { 
                return IsSetField(Fields.CustomTags.EchoDC_04);
            }
            public EchoDC_05 EchoDC_05
            { 
                get 
                {
                    EchoDC_05 val = new EchoDC_05();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(EchoDC_05 val) 
            { 
                this.EchoDC_05 = val;
            }
            
            public EchoDC_05 Get(EchoDC_05 val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(EchoDC_05 val) 
            { 
                return IsSetEchoDC_05();
            }
            
            public bool IsSetEchoDC_05() 
            { 
                return IsSetField(Fields.CustomTags.EchoDC_05);
            }
            public EchoDC_06 EchoDC_06
            { 
                get 
                {
                    EchoDC_06 val = new EchoDC_06();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(EchoDC_06 val) 
            { 
                this.EchoDC_06 = val;
            }
            
            public EchoDC_06 Get(EchoDC_06 val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(EchoDC_06 val) 
            { 
                return IsSetEchoDC_06();
            }
            
            public bool IsSetEchoDC_06() 
            { 
                return IsSetField(Fields.CustomTags.EchoDC_06);
            }
            public EchoDC_07 EchoDC_07
            { 
                get 
                {
                    EchoDC_07 val = new EchoDC_07();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(EchoDC_07 val) 
            { 
                this.EchoDC_07 = val;
            }
            
            public EchoDC_07 Get(EchoDC_07 val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(EchoDC_07 val) 
            { 
                return IsSetEchoDC_07();
            }
            
            public bool IsSetEchoDC_07() 
            { 
                return IsSetField(Fields.CustomTags.EchoDC_07);
            }
            public EchoDC_08 EchoDC_08
            { 
                get 
                {
                    EchoDC_08 val = new EchoDC_08();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(EchoDC_08 val) 
            { 
                this.EchoDC_08 = val;
            }
            
            public EchoDC_08 Get(EchoDC_08 val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(EchoDC_08 val) 
            { 
                return IsSetEchoDC_08();
            }
            
            public bool IsSetEchoDC_08() 
            { 
                return IsSetField(Fields.CustomTags.EchoDC_08);
            }
            public EchoDC_09 EchoDC_09
            { 
                get 
                {
                    EchoDC_09 val = new EchoDC_09();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(EchoDC_09 val) 
            { 
                this.EchoDC_09 = val;
            }
            
            public EchoDC_09 Get(EchoDC_09 val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(EchoDC_09 val) 
            { 
                return IsSetEchoDC_09();
            }
            
            public bool IsSetEchoDC_09() 
            { 
                return IsSetField(Fields.CustomTags.EchoDC_09);
            }
            public EchoDC_10 EchoDC_10
            { 
                get 
                {
                    EchoDC_10 val = new EchoDC_10();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(EchoDC_10 val) 
            { 
                this.EchoDC_10 = val;
            }
            
            public EchoDC_10 Get(EchoDC_10 val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(EchoDC_10 val) 
            { 
                return IsSetEchoDC_10();
            }
            
            public bool IsSetEchoDC_10() 
            { 
                return IsSetField(Fields.CustomTags.EchoDC_10);
            }
            public OrderCapacity OrderCapacity
            { 
                get 
                {
                    OrderCapacity val = new OrderCapacity();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(OrderCapacity val) 
            { 
                this.OrderCapacity = val;
            }
            
            public OrderCapacity Get(OrderCapacity val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(OrderCapacity val) 
            { 
                return IsSetOrderCapacity();
            }
            
            public bool IsSetOrderCapacity() 
            { 
                return IsSetField(Fields.CustomTags.OrderCapacity);
            }
            public OrderOrigination OrderOrigination
            { 
                get 
                {
                    OrderOrigination val = new OrderOrigination();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(OrderOrigination val) 
            { 
                this.OrderOrigination = val;
            }
            
            public OrderOrigination Get(OrderOrigination val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(OrderOrigination val) 
            { 
                return IsSetOrderOrigination();
            }
            
            public bool IsSetOrderOrigination() 
            { 
                return IsSetField(Fields.CustomTags.OrderOrigination);
            }
            public OrderSource OrderSource
            { 
                get 
                {
                    OrderSource val = new OrderSource();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(OrderSource val) 
            { 
                this.OrderSource = val;
            }
            
            public OrderSource Get(OrderSource val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(OrderSource val) 
            { 
                return IsSetOrderSource();
            }
            
            public bool IsSetOrderSource() 
            { 
                return IsSetField(Fields.CustomTags.OrderSource);
            }
            public AccountID AccountID
            { 
                get 
                {
                    AccountID val = new AccountID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(AccountID val) 
            { 
                this.AccountID = val;
            }
            
            public AccountID Get(AccountID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(AccountID val) 
            { 
                return IsSetAccountID();
            }
            
            public bool IsSetAccountID() 
            { 
                return IsSetField(Fields.CustomTags.AccountID);
            }
            public UserID UserID
            { 
                get 
                {
                    UserID val = new UserID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(UserID val) 
            { 
                this.UserID = val;
            }
            
            public UserID Get(UserID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(UserID val) 
            { 
                return IsSetUserID();
            }
            
            public bool IsSetUserID() 
            { 
                return IsSetField(Fields.CustomTags.UserID);
            }
            public Symbol Symbol
            { 
                get 
                {
                    Symbol val = new Symbol();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(Symbol val) 
            { 
                this.Symbol = val;
            }
            
            public Symbol Get(Symbol val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(Symbol val) 
            { 
                return IsSetSymbol();
            }
            
            public bool IsSetSymbol() 
            { 
                return IsSetField(Fields.CustomTags.Symbol);
            }
            public SecurityDesc SecurityDesc
            { 
                get 
                {
                    SecurityDesc val = new SecurityDesc();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(SecurityDesc val) 
            { 
                this.SecurityDesc = val;
            }
            
            public SecurityDesc Get(SecurityDesc val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(SecurityDesc val) 
            { 
                return IsSetSecurityDesc();
            }
            
            public bool IsSetSecurityDesc() 
            { 
                return IsSetField(Fields.CustomTags.SecurityDesc);
            }
            public Product Product
            { 
                get 
                {
                    Product val = new Product();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(Product val) 
            { 
                this.Product = val;
            }
            
            public Product Get(Product val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(Product val) 
            { 
                return IsSetProduct();
            }
            
            public bool IsSetProduct() 
            { 
                return IsSetField(Fields.CustomTags.Product);
            }
            public SecurityID SecurityID
            { 
                get 
                {
                    SecurityID val = new SecurityID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(SecurityID val) 
            { 
                this.SecurityID = val;
            }
            
            public SecurityID Get(SecurityID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(SecurityID val) 
            { 
                return IsSetSecurityID();
            }
            
            public bool IsSetSecurityID() 
            { 
                return IsSetField(Fields.CustomTags.SecurityID);
            }
            public SecurityType SecurityType
            { 
                get 
                {
                    SecurityType val = new SecurityType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(SecurityType val) 
            { 
                this.SecurityType = val;
            }
            
            public SecurityType Get(SecurityType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(SecurityType val) 
            { 
                return IsSetSecurityType();
            }
            
            public bool IsSetSecurityType() 
            { 
                return IsSetField(Fields.CustomTags.SecurityType);
            }
            public SecuritySubType SecuritySubType
            { 
                get 
                {
                    SecuritySubType val = new SecuritySubType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(SecuritySubType val) 
            { 
                this.SecuritySubType = val;
            }
            
            public SecuritySubType Get(SecuritySubType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(SecuritySubType val) 
            { 
                return IsSetSecuritySubType();
            }
            
            public bool IsSetSecuritySubType() 
            { 
                return IsSetField(Fields.CustomTags.SecuritySubType);
            }
            public MaturityMonthYear MaturityMonthYear
            { 
                get 
                {
                    MaturityMonthYear val = new MaturityMonthYear();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(MaturityMonthYear val) 
            { 
                this.MaturityMonthYear = val;
            }
            
            public MaturityMonthYear Get(MaturityMonthYear val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(MaturityMonthYear val) 
            { 
                return IsSetMaturityMonthYear();
            }
            
            public bool IsSetMaturityMonthYear() 
            { 
                return IsSetField(Fields.CustomTags.MaturityMonthYear);
            }
            public MaturityDate MaturityDate
            { 
                get 
                {
                    MaturityDate val = new MaturityDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(MaturityDate val) 
            { 
                this.MaturityDate = val;
            }
            
            public MaturityDate Get(MaturityDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(MaturityDate val) 
            { 
                return IsSetMaturityDate();
            }
            
            public bool IsSetMaturityDate() 
            { 
                return IsSetField(Fields.CustomTags.MaturityDate);
            }
            public MaturityDay MaturityDay
            { 
                get 
                {
                    MaturityDay val = new MaturityDay();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(MaturityDay val) 
            { 
                this.MaturityDay = val;
            }
            
            public MaturityDay Get(MaturityDay val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(MaturityDay val) 
            { 
                return IsSetMaturityDay();
            }
            
            public bool IsSetMaturityDay() 
            { 
                return IsSetField(Fields.CustomTags.MaturityDay);
            }
            public PutOrCall PutOrCall
            { 
                get 
                {
                    PutOrCall val = new PutOrCall();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(PutOrCall val) 
            { 
                this.PutOrCall = val;
            }
            
            public PutOrCall Get(PutOrCall val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(PutOrCall val) 
            { 
                return IsSetPutOrCall();
            }
            
            public bool IsSetPutOrCall() 
            { 
                return IsSetField(Fields.CustomTags.PutOrCall);
            }
            public IDSource IDSource
            { 
                get 
                {
                    IDSource val = new IDSource();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(IDSource val) 
            { 
                this.IDSource = val;
            }
            
            public IDSource Get(IDSource val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(IDSource val) 
            { 
                return IsSetIDSource();
            }
            
            public bool IsSetIDSource() 
            { 
                return IsSetField(Fields.CustomTags.IDSource);
            }
            public StrikePrice StrikePrice
            { 
                get 
                {
                    StrikePrice val = new StrikePrice();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(StrikePrice val) 
            { 
                this.StrikePrice = val;
            }
            
            public StrikePrice Get(StrikePrice val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(StrikePrice val) 
            { 
                return IsSetStrikePrice();
            }
            
            public bool IsSetStrikePrice() 
            { 
                return IsSetField(Fields.CustomTags.StrikePrice);
            }
            public OptAttribute OptAttribute
            { 
                get 
                {
                    OptAttribute val = new OptAttribute();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(OptAttribute val) 
            { 
                this.OptAttribute = val;
            }
            
            public OptAttribute Get(OptAttribute val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(OptAttribute val) 
            { 
                return IsSetOptAttribute();
            }
            
            public bool IsSetOptAttribute() 
            { 
                return IsSetField(Fields.CustomTags.OptAttribute);
            }
            public SecurityExchange SecurityExchange
            { 
                get 
                {
                    SecurityExchange val = new SecurityExchange();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(SecurityExchange val) 
            { 
                this.SecurityExchange = val;
            }
            
            public SecurityExchange Get(SecurityExchange val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(SecurityExchange val) 
            { 
                return IsSetSecurityExchange();
            }
            
            public bool IsSetSecurityExchange() 
            { 
                return IsSetField(Fields.CustomTags.SecurityExchange);
            }
            public ExDestination ExDestination
            { 
                get 
                {
                    ExDestination val = new ExDestination();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(ExDestination val) 
            { 
                this.ExDestination = val;
            }
            
            public ExDestination Get(ExDestination val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(ExDestination val) 
            { 
                return IsSetExDestination();
            }
            
            public bool IsSetExDestination() 
            { 
                return IsSetField(Fields.CustomTags.ExDestination);
            }
            public CFICode CFICode
            { 
                get 
                {
                    CFICode val = new CFICode();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(CFICode val) 
            { 
                this.CFICode = val;
            }
            
            public CFICode Get(CFICode val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(CFICode val) 
            { 
                return IsSetCFICode();
            }
            
            public bool IsSetCFICode() 
            { 
                return IsSetField(Fields.CustomTags.CFICode);
            }
            public Currency Currency
            { 
                get 
                {
                    Currency val = new Currency();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(Currency val) 
            { 
                this.Currency = val;
            }
            
            public Currency Get(Currency val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(Currency val) 
            { 
                return IsSetCurrency();
            }
            
            public bool IsSetCurrency() 
            { 
                return IsSetField(Fields.CustomTags.Currency);
            }
            public DeliveryTerm DeliveryTerm
            { 
                get 
                {
                    DeliveryTerm val = new DeliveryTerm();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(DeliveryTerm val) 
            { 
                this.DeliveryTerm = val;
            }
            
            public DeliveryTerm Get(DeliveryTerm val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(DeliveryTerm val) 
            { 
                return IsSetDeliveryTerm();
            }
            
            public bool IsSetDeliveryTerm() 
            { 
                return IsSetField(Fields.CustomTags.DeliveryTerm);
            }
            public DeliveryDate DeliveryDate
            { 
                get 
                {
                    DeliveryDate val = new DeliveryDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(DeliveryDate val) 
            { 
                this.DeliveryDate = val;
            }
            
            public DeliveryDate Get(DeliveryDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(DeliveryDate val) 
            { 
                return IsSetDeliveryDate();
            }
            
            public bool IsSetDeliveryDate() 
            { 
                return IsSetField(Fields.CustomTags.DeliveryDate);
            }
            public ContractYearMonth ContractYearMonth
            { 
                get 
                {
                    ContractYearMonth val = new ContractYearMonth();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(ContractYearMonth val) 
            { 
                this.ContractYearMonth = val;
            }
            
            public ContractYearMonth Get(ContractYearMonth val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(ContractYearMonth val) 
            { 
                return IsSetContractYearMonth();
            }
            
            public bool IsSetContractYearMonth() 
            { 
                return IsSetField(Fields.CustomTags.ContractYearMonth);
            }
            public LastMkt LastMkt
            { 
                get 
                {
                    LastMkt val = new LastMkt();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(LastMkt val) 
            { 
                this.LastMkt = val;
            }
            
            public LastMkt Get(LastMkt val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(LastMkt val) 
            { 
                return IsSetLastMkt();
            }
            
            public bool IsSetLastMkt() 
            { 
                return IsSetField(Fields.CustomTags.LastMkt);
            }
            public NoSecurityAltID NoSecurityAltID
            { 
                get 
                {
                    NoSecurityAltID val = new NoSecurityAltID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(NoSecurityAltID val) 
            { 
                this.NoSecurityAltID = val;
            }
            
            public NoSecurityAltID Get(NoSecurityAltID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(NoSecurityAltID val) 
            { 
                return IsSetNoSecurityAltID();
            }
            
            public bool IsSetNoSecurityAltID() 
            { 
                return IsSetField(Fields.CustomTags.NoSecurityAltID);
            }
            public AllocID AllocID
            { 
                get 
                {
                    AllocID val = new AllocID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(AllocID val) 
            { 
                this.AllocID = val;
            }
            
            public AllocID Get(AllocID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(AllocID val) 
            { 
                return IsSetAllocID();
            }
            
            public bool IsSetAllocID() 
            { 
                return IsSetField(Fields.CustomTags.AllocID);
            }
            public NoLegs NoLegs
            { 
                get 
                {
                    NoLegs val = new NoLegs();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(NoLegs val) 
            { 
                this.NoLegs = val;
            }
            
            public NoLegs Get(NoLegs val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(NoLegs val) 
            { 
                return IsSetNoLegs();
            }
            
            public bool IsSetNoLegs() 
            { 
                return IsSetField(Fields.CustomTags.NoLegs);
            }
            public CustOrderHandlingInst CustOrderHandlingInst
            { 
                get 
                {
                    CustOrderHandlingInst val = new CustOrderHandlingInst();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(CustOrderHandlingInst val) 
            { 
                this.CustOrderHandlingInst = val;
            }
            
            public CustOrderHandlingInst Get(CustOrderHandlingInst val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(CustOrderHandlingInst val) 
            { 
                return IsSetCustOrderHandlingInst();
            }
            
            public bool IsSetCustOrderHandlingInst() 
            { 
                return IsSetField(Fields.CustomTags.CustOrderHandlingInst);
            }
            public TTSyntheticType TTSyntheticType
            { 
                get 
                {
                    TTSyntheticType val = new TTSyntheticType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(TTSyntheticType val) 
            { 
                this.TTSyntheticType = val;
            }
            
            public TTSyntheticType Get(TTSyntheticType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(TTSyntheticType val) 
            { 
                return IsSetTTSyntheticType();
            }
            
            public bool IsSetTTSyntheticType() 
            { 
                return IsSetField(Fields.CustomTags.TTSyntheticType);
            }
            public TTCustomerName TTCustomerName
            { 
                get 
                {
                    TTCustomerName val = new TTCustomerName();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(TTCustomerName val) 
            { 
                this.TTCustomerName = val;
            }
            
            public TTCustomerName Get(TTCustomerName val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(TTCustomerName val) 
            { 
                return IsSetTTCustomerName();
            }
            
            public bool IsSetTTCustomerName() 
            { 
                return IsSetField(Fields.CustomTags.TTCustomerName);
            }
            public Organization Organization
            { 
                get 
                {
                    Organization val = new Organization();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(Organization val) 
            { 
                this.Organization = val;
            }
            
            public Organization Get(Organization val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(Organization val) 
            { 
                return IsSetOrganization();
            }
            
            public bool IsSetOrganization() 
            { 
                return IsSetField(Fields.CustomTags.Organization);
            }
            public class NoStrategyParametersGroup : Group
            {
                public static int[] fieldOrder = {Fields.CustomTags.StrategyParameterName, Fields.CustomTags.StrategyParameterType, Fields.CustomTags.StrategyParameterValue, 0};
            
                public NoStrategyParametersGroup() 
                  :base( Fields.CustomTags.NoStrategyParameters, Fields.CustomTags.StrategyParameterName, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoStrategyParametersGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                public StrategyParameterName StrategyParameterName
                { 
                    get 
                    {
                        StrategyParameterName val = new StrategyParameterName();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(StrategyParameterName val) 
                { 
                    this.StrategyParameterName = val;
                }
                
                public StrategyParameterName Get(StrategyParameterName val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(StrategyParameterName val) 
                { 
                    return IsSetStrategyParameterName();
                }
                
                public bool IsSetStrategyParameterName() 
                { 
                    return IsSetField(Fields.CustomTags.StrategyParameterName);
                }
                public StrategyParameterType StrategyParameterType
                { 
                    get 
                    {
                        StrategyParameterType val = new StrategyParameterType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(StrategyParameterType val) 
                { 
                    this.StrategyParameterType = val;
                }
                
                public StrategyParameterType Get(StrategyParameterType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(StrategyParameterType val) 
                { 
                    return IsSetStrategyParameterType();
                }
                
                public bool IsSetStrategyParameterType() 
                { 
                    return IsSetField(Fields.CustomTags.StrategyParameterType);
                }
                public StrategyParameterValue StrategyParameterValue
                { 
                    get 
                    {
                        StrategyParameterValue val = new StrategyParameterValue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(StrategyParameterValue val) 
                { 
                    this.StrategyParameterValue = val;
                }
                
                public StrategyParameterValue Get(StrategyParameterValue val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(StrategyParameterValue val) 
                { 
                    return IsSetStrategyParameterValue();
                }
                
                public bool IsSetStrategyParameterValue() 
                { 
                    return IsSetField(Fields.CustomTags.StrategyParameterValue);
                }
            
            }
            public class NoSecurityAltIDGroup : Group
            {
                public static int[] fieldOrder = {Fields.CustomTags.SecurityAltID, Fields.CustomTags.SecurityAltIDSource, 0};
            
                public NoSecurityAltIDGroup() 
                  :base( Fields.CustomTags.NoSecurityAltID, Fields.CustomTags.SecurityAltID, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoSecurityAltIDGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                public SecurityAltID SecurityAltID
                { 
                    get 
                    {
                        SecurityAltID val = new SecurityAltID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(SecurityAltID val) 
                { 
                    this.SecurityAltID = val;
                }
                
                public SecurityAltID Get(SecurityAltID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(SecurityAltID val) 
                { 
                    return IsSetSecurityAltID();
                }
                
                public bool IsSetSecurityAltID() 
                { 
                    return IsSetField(Fields.CustomTags.SecurityAltID);
                }
                public SecurityAltIDSource SecurityAltIDSource
                { 
                    get 
                    {
                        SecurityAltIDSource val = new SecurityAltIDSource();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(SecurityAltIDSource val) 
                { 
                    this.SecurityAltIDSource = val;
                }
                
                public SecurityAltIDSource Get(SecurityAltIDSource val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(SecurityAltIDSource val) 
                { 
                    return IsSetSecurityAltIDSource();
                }
                
                public bool IsSetSecurityAltIDSource() 
                { 
                    return IsSetField(Fields.CustomTags.SecurityAltIDSource);
                }
            
            }
            public class NoLegsGroup : Group
            {
                public static int[] fieldOrder = {Fields.CustomTags.LegSymbol, Fields.CustomTags.LegSecurityDesc, Fields.CustomTags.LegProduct, Fields.CustomTags.LegSecurityID, Fields.CustomTags.LegIDSource, Fields.CustomTags.LegSecurityType, Fields.CustomTags.LegSecuritySubType, Fields.CustomTags.LegMaturityMonthYear, Fields.CustomTags.LegMaturityDate, Fields.CustomTags.LegMaturityDay, Fields.CustomTags.LegStrikePrice, Fields.CustomTags.LegPutOrCall, Fields.CustomTags.LegOptAttribute, Fields.CustomTags.LegSecurityExchange, Fields.CustomTags.LegExDestination, Fields.CustomTags.LegCFICode, Fields.CustomTags.LegSide, Fields.CustomTags.LegRatioQty, Fields.CustomTags.LegCurrency, Fields.CustomTags.LegDeliveryTerm, Fields.CustomTags.LegDeliveryDate, Fields.CustomTags.LegContractYearMonth, Fields.CustomTags.LegQty, Fields.CustomTags.LegRefID, Fields.CustomTags.LegPrice, Fields.CustomTags.LegLastPx, Fields.CustomTags.LegAllocID, Fields.CustomTags.NoLegSecurityAltID, Fields.CustomTags.LegNoFills, 0};
            
                public NoLegsGroup() 
                  :base( Fields.CustomTags.NoLegs, Fields.CustomTags.LegSymbol, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoLegsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                public LegSymbol LegSymbol
                { 
                    get 
                    {
                        LegSymbol val = new LegSymbol();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(LegSymbol val) 
                { 
                    this.LegSymbol = val;
                }
                
                public LegSymbol Get(LegSymbol val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(LegSymbol val) 
                { 
                    return IsSetLegSymbol();
                }
                
                public bool IsSetLegSymbol() 
                { 
                    return IsSetField(Fields.CustomTags.LegSymbol);
                }
                public LegSecurityDesc LegSecurityDesc
                { 
                    get 
                    {
                        LegSecurityDesc val = new LegSecurityDesc();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(LegSecurityDesc val) 
                { 
                    this.LegSecurityDesc = val;
                }
                
                public LegSecurityDesc Get(LegSecurityDesc val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(LegSecurityDesc val) 
                { 
                    return IsSetLegSecurityDesc();
                }
                
                public bool IsSetLegSecurityDesc() 
                { 
                    return IsSetField(Fields.CustomTags.LegSecurityDesc);
                }
                public LegProduct LegProduct
                { 
                    get 
                    {
                        LegProduct val = new LegProduct();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(LegProduct val) 
                { 
                    this.LegProduct = val;
                }
                
                public LegProduct Get(LegProduct val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(LegProduct val) 
                { 
                    return IsSetLegProduct();
                }
                
                public bool IsSetLegProduct() 
                { 
                    return IsSetField(Fields.CustomTags.LegProduct);
                }
                public LegSecurityID LegSecurityID
                { 
                    get 
                    {
                        LegSecurityID val = new LegSecurityID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(LegSecurityID val) 
                { 
                    this.LegSecurityID = val;
                }
                
                public LegSecurityID Get(LegSecurityID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(LegSecurityID val) 
                { 
                    return IsSetLegSecurityID();
                }
                
                public bool IsSetLegSecurityID() 
                { 
                    return IsSetField(Fields.CustomTags.LegSecurityID);
                }
                public LegIDSource LegIDSource
                { 
                    get 
                    {
                        LegIDSource val = new LegIDSource();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(LegIDSource val) 
                { 
                    this.LegIDSource = val;
                }
                
                public LegIDSource Get(LegIDSource val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(LegIDSource val) 
                { 
                    return IsSetLegIDSource();
                }
                
                public bool IsSetLegIDSource() 
                { 
                    return IsSetField(Fields.CustomTags.LegIDSource);
                }
                public LegSecurityType LegSecurityType
                { 
                    get 
                    {
                        LegSecurityType val = new LegSecurityType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(LegSecurityType val) 
                { 
                    this.LegSecurityType = val;
                }
                
                public LegSecurityType Get(LegSecurityType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(LegSecurityType val) 
                { 
                    return IsSetLegSecurityType();
                }
                
                public bool IsSetLegSecurityType() 
                { 
                    return IsSetField(Fields.CustomTags.LegSecurityType);
                }
                public LegSecuritySubType LegSecuritySubType
                { 
                    get 
                    {
                        LegSecuritySubType val = new LegSecuritySubType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(LegSecuritySubType val) 
                { 
                    this.LegSecuritySubType = val;
                }
                
                public LegSecuritySubType Get(LegSecuritySubType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(LegSecuritySubType val) 
                { 
                    return IsSetLegSecuritySubType();
                }
                
                public bool IsSetLegSecuritySubType() 
                { 
                    return IsSetField(Fields.CustomTags.LegSecuritySubType);
                }
                public LegMaturityMonthYear LegMaturityMonthYear
                { 
                    get 
                    {
                        LegMaturityMonthYear val = new LegMaturityMonthYear();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(LegMaturityMonthYear val) 
                { 
                    this.LegMaturityMonthYear = val;
                }
                
                public LegMaturityMonthYear Get(LegMaturityMonthYear val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(LegMaturityMonthYear val) 
                { 
                    return IsSetLegMaturityMonthYear();
                }
                
                public bool IsSetLegMaturityMonthYear() 
                { 
                    return IsSetField(Fields.CustomTags.LegMaturityMonthYear);
                }
                public LegMaturityDate LegMaturityDate
                { 
                    get 
                    {
                        LegMaturityDate val = new LegMaturityDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(LegMaturityDate val) 
                { 
                    this.LegMaturityDate = val;
                }
                
                public LegMaturityDate Get(LegMaturityDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(LegMaturityDate val) 
                { 
                    return IsSetLegMaturityDate();
                }
                
                public bool IsSetLegMaturityDate() 
                { 
                    return IsSetField(Fields.CustomTags.LegMaturityDate);
                }
                public LegMaturityDay LegMaturityDay
                { 
                    get 
                    {
                        LegMaturityDay val = new LegMaturityDay();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(LegMaturityDay val) 
                { 
                    this.LegMaturityDay = val;
                }
                
                public LegMaturityDay Get(LegMaturityDay val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(LegMaturityDay val) 
                { 
                    return IsSetLegMaturityDay();
                }
                
                public bool IsSetLegMaturityDay() 
                { 
                    return IsSetField(Fields.CustomTags.LegMaturityDay);
                }
                public LegStrikePrice LegStrikePrice
                { 
                    get 
                    {
                        LegStrikePrice val = new LegStrikePrice();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(LegStrikePrice val) 
                { 
                    this.LegStrikePrice = val;
                }
                
                public LegStrikePrice Get(LegStrikePrice val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(LegStrikePrice val) 
                { 
                    return IsSetLegStrikePrice();
                }
                
                public bool IsSetLegStrikePrice() 
                { 
                    return IsSetField(Fields.CustomTags.LegStrikePrice);
                }
                public LegPutOrCall LegPutOrCall
                { 
                    get 
                    {
                        LegPutOrCall val = new LegPutOrCall();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(LegPutOrCall val) 
                { 
                    this.LegPutOrCall = val;
                }
                
                public LegPutOrCall Get(LegPutOrCall val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(LegPutOrCall val) 
                { 
                    return IsSetLegPutOrCall();
                }
                
                public bool IsSetLegPutOrCall() 
                { 
                    return IsSetField(Fields.CustomTags.LegPutOrCall);
                }
                public LegOptAttribute LegOptAttribute
                { 
                    get 
                    {
                        LegOptAttribute val = new LegOptAttribute();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(LegOptAttribute val) 
                { 
                    this.LegOptAttribute = val;
                }
                
                public LegOptAttribute Get(LegOptAttribute val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(LegOptAttribute val) 
                { 
                    return IsSetLegOptAttribute();
                }
                
                public bool IsSetLegOptAttribute() 
                { 
                    return IsSetField(Fields.CustomTags.LegOptAttribute);
                }
                public LegSecurityExchange LegSecurityExchange
                { 
                    get 
                    {
                        LegSecurityExchange val = new LegSecurityExchange();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(LegSecurityExchange val) 
                { 
                    this.LegSecurityExchange = val;
                }
                
                public LegSecurityExchange Get(LegSecurityExchange val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(LegSecurityExchange val) 
                { 
                    return IsSetLegSecurityExchange();
                }
                
                public bool IsSetLegSecurityExchange() 
                { 
                    return IsSetField(Fields.CustomTags.LegSecurityExchange);
                }
                public LegExDestination LegExDestination
                { 
                    get 
                    {
                        LegExDestination val = new LegExDestination();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(LegExDestination val) 
                { 
                    this.LegExDestination = val;
                }
                
                public LegExDestination Get(LegExDestination val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(LegExDestination val) 
                { 
                    return IsSetLegExDestination();
                }
                
                public bool IsSetLegExDestination() 
                { 
                    return IsSetField(Fields.CustomTags.LegExDestination);
                }
                public LegCFICode LegCFICode
                { 
                    get 
                    {
                        LegCFICode val = new LegCFICode();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(LegCFICode val) 
                { 
                    this.LegCFICode = val;
                }
                
                public LegCFICode Get(LegCFICode val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(LegCFICode val) 
                { 
                    return IsSetLegCFICode();
                }
                
                public bool IsSetLegCFICode() 
                { 
                    return IsSetField(Fields.CustomTags.LegCFICode);
                }
                public LegSide LegSide
                { 
                    get 
                    {
                        LegSide val = new LegSide();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(LegSide val) 
                { 
                    this.LegSide = val;
                }
                
                public LegSide Get(LegSide val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(LegSide val) 
                { 
                    return IsSetLegSide();
                }
                
                public bool IsSetLegSide() 
                { 
                    return IsSetField(Fields.CustomTags.LegSide);
                }
                public LegRatioQty LegRatioQty
                { 
                    get 
                    {
                        LegRatioQty val = new LegRatioQty();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(LegRatioQty val) 
                { 
                    this.LegRatioQty = val;
                }
                
                public LegRatioQty Get(LegRatioQty val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(LegRatioQty val) 
                { 
                    return IsSetLegRatioQty();
                }
                
                public bool IsSetLegRatioQty() 
                { 
                    return IsSetField(Fields.CustomTags.LegRatioQty);
                }
                public LegCurrency LegCurrency
                { 
                    get 
                    {
                        LegCurrency val = new LegCurrency();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(LegCurrency val) 
                { 
                    this.LegCurrency = val;
                }
                
                public LegCurrency Get(LegCurrency val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(LegCurrency val) 
                { 
                    return IsSetLegCurrency();
                }
                
                public bool IsSetLegCurrency() 
                { 
                    return IsSetField(Fields.CustomTags.LegCurrency);
                }
                public LegDeliveryTerm LegDeliveryTerm
                { 
                    get 
                    {
                        LegDeliveryTerm val = new LegDeliveryTerm();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(LegDeliveryTerm val) 
                { 
                    this.LegDeliveryTerm = val;
                }
                
                public LegDeliveryTerm Get(LegDeliveryTerm val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(LegDeliveryTerm val) 
                { 
                    return IsSetLegDeliveryTerm();
                }
                
                public bool IsSetLegDeliveryTerm() 
                { 
                    return IsSetField(Fields.CustomTags.LegDeliveryTerm);
                }
                public LegDeliveryDate LegDeliveryDate
                { 
                    get 
                    {
                        LegDeliveryDate val = new LegDeliveryDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(LegDeliveryDate val) 
                { 
                    this.LegDeliveryDate = val;
                }
                
                public LegDeliveryDate Get(LegDeliveryDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(LegDeliveryDate val) 
                { 
                    return IsSetLegDeliveryDate();
                }
                
                public bool IsSetLegDeliveryDate() 
                { 
                    return IsSetField(Fields.CustomTags.LegDeliveryDate);
                }
                public LegContractYearMonth LegContractYearMonth
                { 
                    get 
                    {
                        LegContractYearMonth val = new LegContractYearMonth();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(LegContractYearMonth val) 
                { 
                    this.LegContractYearMonth = val;
                }
                
                public LegContractYearMonth Get(LegContractYearMonth val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(LegContractYearMonth val) 
                { 
                    return IsSetLegContractYearMonth();
                }
                
                public bool IsSetLegContractYearMonth() 
                { 
                    return IsSetField(Fields.CustomTags.LegContractYearMonth);
                }
                public LegQty LegQty
                { 
                    get 
                    {
                        LegQty val = new LegQty();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(LegQty val) 
                { 
                    this.LegQty = val;
                }
                
                public LegQty Get(LegQty val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(LegQty val) 
                { 
                    return IsSetLegQty();
                }
                
                public bool IsSetLegQty() 
                { 
                    return IsSetField(Fields.CustomTags.LegQty);
                }
                public LegRefID LegRefID
                { 
                    get 
                    {
                        LegRefID val = new LegRefID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(LegRefID val) 
                { 
                    this.LegRefID = val;
                }
                
                public LegRefID Get(LegRefID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(LegRefID val) 
                { 
                    return IsSetLegRefID();
                }
                
                public bool IsSetLegRefID() 
                { 
                    return IsSetField(Fields.CustomTags.LegRefID);
                }
                public LegPrice LegPrice
                { 
                    get 
                    {
                        LegPrice val = new LegPrice();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(LegPrice val) 
                { 
                    this.LegPrice = val;
                }
                
                public LegPrice Get(LegPrice val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(LegPrice val) 
                { 
                    return IsSetLegPrice();
                }
                
                public bool IsSetLegPrice() 
                { 
                    return IsSetField(Fields.CustomTags.LegPrice);
                }
                public LegLastPx LegLastPx
                { 
                    get 
                    {
                        LegLastPx val = new LegLastPx();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(LegLastPx val) 
                { 
                    this.LegLastPx = val;
                }
                
                public LegLastPx Get(LegLastPx val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(LegLastPx val) 
                { 
                    return IsSetLegLastPx();
                }
                
                public bool IsSetLegLastPx() 
                { 
                    return IsSetField(Fields.CustomTags.LegLastPx);
                }
                public LegAllocID LegAllocID
                { 
                    get 
                    {
                        LegAllocID val = new LegAllocID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(LegAllocID val) 
                { 
                    this.LegAllocID = val;
                }
                
                public LegAllocID Get(LegAllocID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(LegAllocID val) 
                { 
                    return IsSetLegAllocID();
                }
                
                public bool IsSetLegAllocID() 
                { 
                    return IsSetField(Fields.CustomTags.LegAllocID);
                }
                public NoLegSecurityAltID NoLegSecurityAltID
                { 
                    get 
                    {
                        NoLegSecurityAltID val = new NoLegSecurityAltID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(NoLegSecurityAltID val) 
                { 
                    this.NoLegSecurityAltID = val;
                }
                
                public NoLegSecurityAltID Get(NoLegSecurityAltID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(NoLegSecurityAltID val) 
                { 
                    return IsSetNoLegSecurityAltID();
                }
                
                public bool IsSetNoLegSecurityAltID() 
                { 
                    return IsSetField(Fields.CustomTags.NoLegSecurityAltID);
                }
                public LegNoFills LegNoFills
                { 
                    get 
                    {
                        LegNoFills val = new LegNoFills();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(LegNoFills val) 
                { 
                    this.LegNoFills = val;
                }
                
                public LegNoFills Get(LegNoFills val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(LegNoFills val) 
                { 
                    return IsSetLegNoFills();
                }
                
                public bool IsSetLegNoFills() 
                { 
                    return IsSetField(Fields.CustomTags.LegNoFills);
                }
                            public class NoLegSecurityAltIDGroup : Group
                {
                    public static int[] fieldOrder = {Fields.CustomTags.LegSecurityAltID, Fields.CustomTags.LegSecurityAltIDSource, 0};
                
                    public NoLegSecurityAltIDGroup() 
                      :base( Fields.CustomTags.NoLegSecurityAltID, Fields.CustomTags.LegSecurityAltID, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoLegSecurityAltIDGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }
                
                    public LegSecurityAltID LegSecurityAltID
                    { 
                        get 
                        {
                            LegSecurityAltID val = new LegSecurityAltID();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(LegSecurityAltID val) 
                    { 
                        this.LegSecurityAltID = val;
                    }
                    
                    public LegSecurityAltID Get(LegSecurityAltID val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(LegSecurityAltID val) 
                    { 
                        return IsSetLegSecurityAltID();
                    }
                    
                    public bool IsSetLegSecurityAltID() 
                    { 
                        return IsSetField(Fields.CustomTags.LegSecurityAltID);
                    }
                    public LegSecurityAltIDSource LegSecurityAltIDSource
                    { 
                        get 
                        {
                            LegSecurityAltIDSource val = new LegSecurityAltIDSource();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(LegSecurityAltIDSource val) 
                    { 
                        this.LegSecurityAltIDSource = val;
                    }
                    
                    public LegSecurityAltIDSource Get(LegSecurityAltIDSource val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(LegSecurityAltIDSource val) 
                    { 
                        return IsSetLegSecurityAltIDSource();
                    }
                    
                    public bool IsSetLegSecurityAltIDSource() 
                    { 
                        return IsSetField(Fields.CustomTags.LegSecurityAltIDSource);
                    }
                
                }
                public class LegNoFillsGroup : Group
                {
                    public static int[] fieldOrder = {Fields.CustomTags.LegFillExecID, Fields.CustomTags.LegFillPx, Fields.CustomTags.LegFillQty, Fields.CustomTags.LegFillTradingVenueRegulatoryTradeID, Fields.CustomTags.LegFillLastLiquidityIndicator, 0};
                
                    public LegNoFillsGroup() 
                      :base( Fields.CustomTags.LegNoFills, Fields.CustomTags.LegFillExecID, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new LegNoFillsGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }
                
                    public LegFillExecID LegFillExecID
                    { 
                        get 
                        {
                            LegFillExecID val = new LegFillExecID();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(LegFillExecID val) 
                    { 
                        this.LegFillExecID = val;
                    }
                    
                    public LegFillExecID Get(LegFillExecID val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(LegFillExecID val) 
                    { 
                        return IsSetLegFillExecID();
                    }
                    
                    public bool IsSetLegFillExecID() 
                    { 
                        return IsSetField(Fields.CustomTags.LegFillExecID);
                    }
                    public LegFillPx LegFillPx
                    { 
                        get 
                        {
                            LegFillPx val = new LegFillPx();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(LegFillPx val) 
                    { 
                        this.LegFillPx = val;
                    }
                    
                    public LegFillPx Get(LegFillPx val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(LegFillPx val) 
                    { 
                        return IsSetLegFillPx();
                    }
                    
                    public bool IsSetLegFillPx() 
                    { 
                        return IsSetField(Fields.CustomTags.LegFillPx);
                    }
                    public LegFillQty LegFillQty
                    { 
                        get 
                        {
                            LegFillQty val = new LegFillQty();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(LegFillQty val) 
                    { 
                        this.LegFillQty = val;
                    }
                    
                    public LegFillQty Get(LegFillQty val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(LegFillQty val) 
                    { 
                        return IsSetLegFillQty();
                    }
                    
                    public bool IsSetLegFillQty() 
                    { 
                        return IsSetField(Fields.CustomTags.LegFillQty);
                    }
                    public LegFillTradingVenueRegulatoryTradeID LegFillTradingVenueRegulatoryTradeID
                    { 
                        get 
                        {
                            LegFillTradingVenueRegulatoryTradeID val = new LegFillTradingVenueRegulatoryTradeID();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(LegFillTradingVenueRegulatoryTradeID val) 
                    { 
                        this.LegFillTradingVenueRegulatoryTradeID = val;
                    }
                    
                    public LegFillTradingVenueRegulatoryTradeID Get(LegFillTradingVenueRegulatoryTradeID val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(LegFillTradingVenueRegulatoryTradeID val) 
                    { 
                        return IsSetLegFillTradingVenueRegulatoryTradeID();
                    }
                    
                    public bool IsSetLegFillTradingVenueRegulatoryTradeID() 
                    { 
                        return IsSetField(Fields.CustomTags.LegFillTradingVenueRegulatoryTradeID);
                    }
                    public LegFillLastLiquidityIndicator LegFillLastLiquidityIndicator
                    { 
                        get 
                        {
                            LegFillLastLiquidityIndicator val = new LegFillLastLiquidityIndicator();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(LegFillLastLiquidityIndicator val) 
                    { 
                        this.LegFillLastLiquidityIndicator = val;
                    }
                    
                    public LegFillLastLiquidityIndicator Get(LegFillLastLiquidityIndicator val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(LegFillLastLiquidityIndicator val) 
                    { 
                        return IsSetLegFillLastLiquidityIndicator();
                    }
                    
                    public bool IsSetLegFillLastLiquidityIndicator() 
                    { 
                        return IsSetField(Fields.CustomTags.LegFillLastLiquidityIndicator);
                    }
                
                }
            }
        }
    }
}
