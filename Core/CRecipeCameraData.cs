using System.Windows.Forms;
using System.Xml.Serialization;

namespace Core
{

	public class CRecipeCameraData
	{
		
		private int Threshold_ = 1;

		private int Threshold1_ = 1;

		private double hvROI_ROW01_ = 0.1;

		private double hvROI_ROW02_ = 0.1;

		private double hvROI_COL01_ = 0.1;

		private double hvROI_COL02_ = 0.1;

		private double hvLROI_ROW1_ = 0.1;

		private double hvLROI_COL1_ = 0.1;

		private double hvLROI_ROW2_ = 0.1;

		private double hvLROI_COL2_ = 0.1;

		private double hvRROI_ROW1_ = 0.1;

		private double hvRROI_COL1_ = 0.1;

		private double hvRROI_ROW2_ = 0.1;

		private double hvRROI_COL2_ = 0.1;

		private double hvUpROI_ROW1_ = 0.1;

		private double hvUpROI_COL1_ = 0.1;

		private double hvUpROI_ROW2_ = 0.1;

		private double hvUpROI_COL2_ = 0.1;

		private double hvDwROI_ROW1_ = 0.1;

		private double hvDwROI_COL1_ = 0.1;

		private double hvDwROI_ROW2_ = 0.1;

		private double hvDwROI_COL2_ = 0.1;

		private double hvDownNewROI_ROW1_ = 0.1;

		private double hvDownNewROI_COL1_ = 0.1;

		private double hvDownNewROI_ROW2_ = 0.1;

		private double hvDownNewROI_COL2_ = 0.1;

		private double hvDownNewROI_ROW1_1_ = 0.1;

		private double hvDownNewROI_COL1_1_ = 0.1;

		private double hvDownNewROI_ROW2_2_ = 0.1;

		private double hvDownNewROI_COL2_2_ = 0.1;

		private double hv_OrgModelRow1_ = 0.1;

		private double hv_OrgModelColumn1_ = 0.1;

		private double hv_OrgModelAngle1_ = 0.1;

		private double hvCalibrationRow_ = 0.1;

		private double hvCalibrationCol_ = 0.1;

		private double hvCalibrationRadus_ = 0.1;

		private double hvUpAreaMin_ = 0.1;

		private double hvUpAreaMax_ = 0.1;

		private double hvDwAreaMin_ = 0.1;

		private double hvDwAreaMax_ = 0.1;

		private double hvLAreaMin_ = 0.1;

		private double hvLAreaMax_ = 0.1;

		private double hvRAreaMin_ = 0.1;

		private double hvRAreaMax_ = 0.1;

		private double hvUpCameraResRow_ = 0.1;

		private double hvUpCameraResCol_ = 0.1;

		private double hvDwCameraResRow_ = 0.1;

		private double hvDwCameraResCol_ = 0.1;

		private double hvRotaCenRow1_ = 0.1;

		private double hvRotaCenCol1_ = 0.1;

		private double hvRotaCenRow2_ = 0.1;

		private double hvRotaCenCol2_ = 0.1;

		private double hvRotaCenRow3_ = 0.1;

		private double hvRotaCenCol3_ = 0.1;

		private double hvRotaCenRow4_ = 0.1;

		private double hvRotaCenCol4_ = 0.1;

		private double hvUDOffsetAgle_ = 0.1;

		private int iOKPicSave_ = 0;

		private int iNGPicSave_ = 0;

		private int iniUpCameraTime_ = 0;

		private int iniUpExposureTime_ = 1000;

		private double iniUpCameraGain_ = 0.0;

		private int iniDelaySendTime_ = 300;

		private int iniDownCameraTime_ = 0;

		private int iniDownExposureTime_ = 1000;

		private int iniSaveNGDayCmbIndex_ = 0;

		private int iniStartSaveDay_ = 0;

		private int iniStartSaveMonth_ = 0;

		private double iniDownRow_ = 0.0;

		private double iniDownCol_ = 0.0;

		private double iniDownPhi_ = 0.0;

		private double iniDownLength11_ = 0.0;

		private double iniDownLength21_ = 0.0;

		private double iniLeftRow_ = 0.0;

		private double iniLeftCol_ = 0.0;

		private double iniLeftPhi_ = 0.0;

		private double iniLeftLength11_ = 0.0;

		private double iniLeftLength21_ = 0.0;

		private string iniProjectNO_ = "01";

		private double iniUpOffset_ = 2.0;

		private double iniDownOffset_ = 2.0;

		private double iniLeftOffset_ = 2.0;

		private double iniRightOffset_ = 2.0;

		private double iniAngleOffset_ = 5.0;

		private double iniAreaOffset_ = 10000.0;

		private double iniMatchValue_ = 0.8;

		private int iniThresholdValue_ = 100;

		private double iniScale_ = 4.5;

		[XmlElement]
		public int Threshold
		{
			get
			{
				return Threshold_;
			}
			set
			{
				Threshold_ = value;
			}
		}

		[XmlElement]
		public int Threshold1
		{
			get
			{
				return Threshold1_;
			}
			set
			{
				Threshold1_ = value;
			}
		}

		[XmlElement]
		public double hvROI_ROW01
		{
			get
			{
				return hvROI_ROW01_;
			}
			set
			{
				hvROI_ROW01_ = value;
			}
		}

		[XmlElement]
		public double hvROI_ROW02
		{
			get
			{
				return hvROI_ROW02_;
			}
			set
			{
				hvROI_ROW02_ = value;
			}
		}

		[XmlElement]
		public double hvROI_COL01
		{
			get
			{
				return hvROI_COL01_;
			}
			set
			{
				hvROI_COL01_ = value;
			}
		}

		[XmlElement]
		public double hvROI_COL02
		{
			get
			{
				return hvROI_COL02_;
			}
			set
			{
				hvROI_COL02_ = value;
			}
		}

		[XmlElement]
		public double hvLROI_ROW1
		{
			get
			{
				return hvLROI_ROW1_;
			}
			set
			{
				hvLROI_ROW1_ = value;
			}
		}

		[XmlElement]
		public double hvLROI_COL1
		{
			get
			{
				return hvLROI_COL1_;
			}
			set
			{
				hvLROI_COL1_ = value;
			}
		}

		[XmlElement]
		public double hvLROI_ROW2
		{
			get
			{
				return hvLROI_ROW2_;
			}
			set
			{
				hvLROI_ROW2_ = value;
			}
		}

		[XmlElement]
		public double hvLROI_COL2
		{
			get
			{
				return hvLROI_COL2_;
			}
			set
			{
				hvLROI_COL2_ = value;
			}
		}

		[XmlElement]
		public double hvRROI_ROW1
		{
			get
			{
				return hvRROI_ROW1_;
			}
			set
			{
				hvRROI_ROW1_ = value;
			}
		}

		[XmlElement]
		public double hvRROI_COL1
		{
			get
			{
				return hvRROI_COL1_;
			}
			set
			{
				hvRROI_COL1_ = value;
			}
		}

		[XmlElement]
		public double hvRROI_ROW2
		{
			get
			{
				return hvRROI_ROW2_;
			}
			set
			{
				hvRROI_ROW2_ = value;
			}
		}

		[XmlElement]
		public double hvRROI_COL2
		{
			get
			{
				return hvRROI_COL2_;
			}
			set
			{
				hvRROI_COL2_ = value;
			}
		}

		[XmlElement]
		public double hvUpROI_ROW1
		{
			get
			{
				return hvUpROI_ROW1_;
			}
			set
			{
				hvUpROI_ROW1_ = value;
			}
		}

		[XmlElement]
		public double hvUpROI_COL1
		{
			get
			{
				return hvUpROI_COL1_;
			}
			set
			{
				hvUpROI_COL1_ = value;
			}
		}

		[XmlElement]
		public double hvUpROI_ROW2
		{
			get
			{
				return hvUpROI_ROW2_;
			}
			set
			{
				hvUpROI_ROW2_ = value;
			}
		}

		[XmlElement]
		public double hvUpROI_COL2
		{
			get
			{
				return hvUpROI_COL2_;
			}
			set
			{
				hvUpROI_COL2_ = value;
			}
		}

		[XmlElement]
		public double hvDwROI_ROW1
		{
			get
			{
				return hvDwROI_ROW1_;
			}
			set
			{
				hvDwROI_ROW1_ = value;
			}
		}

		[XmlElement]
		public double hvDwROI_COL1
		{
			get
			{
				return hvDwROI_COL1_;
			}
			set
			{
				hvDwROI_COL1_ = value;
			}
		}

		[XmlElement]
		public double hvDwROI_ROW2
		{
			get
			{
				return hvDwROI_ROW2_;
			}
			set
			{
				hvDwROI_ROW2_ = value;
			}
		}

		[XmlElement]
		public double hvDwROI_COL2
		{
			get
			{
				return hvDwROI_COL2_;
			}
			set
			{
				hvDwROI_COL2_ = value;
			}
		}

		[XmlElement]
		public double hvDownNewROI_ROW1
		{
			get
			{
				return hvDownNewROI_ROW1_;
			}
			set
			{
				hvDownNewROI_ROW1_ = value;
			}
		}

		[XmlElement]
		public double hvDownNewROI_COL1
		{
			get
			{
				return hvDownNewROI_COL1_;
			}
			set
			{
				hvDownNewROI_COL1_ = value;
			}
		}

		[XmlElement]
		public double hvDownNewROI_ROW2
		{
			get
			{
				return hvDownNewROI_ROW2_;
			}
			set
			{
				hvDownNewROI_ROW2_ = value;
			}
		}

		[XmlElement]
		public double hvDownNewROI_COL2
		{
			get
			{
				return hvDownNewROI_COL2_;
			}
			set
			{
				hvDownNewROI_COL2_ = value;
			}
		}

		[XmlElement]
		public double hvDownNewROI_ROW1_1
		{
			get
			{
				return hvDownNewROI_ROW1_1_;
			}
			set
			{
				hvDownNewROI_ROW1_1_ = value;
			}
		}

		[XmlElement]
		public double hvDownNewROI_COL1_1
		{
			get
			{
				return hvDownNewROI_COL1_1_;
			}
			set
			{
				hvDownNewROI_COL1_1_ = value;
			}
		}

		[XmlElement]
		public double hvDownNewROI_ROW2_2
		{
			get
			{
				return hvDownNewROI_ROW2_2_;
			}
			set
			{
				hvDownNewROI_ROW2_2_ = value;
			}
		}

		[XmlElement]
		public double hvDownNewROI_COL2_2
		{
			get
			{
				return hvDownNewROI_COL2_2_;
			}
			set
			{
				hvDownNewROI_COL2_2_ = value;
			}
		}

		[XmlElement]
		public double hv_OrgModelRow1
		{
			get
			{
				return hv_OrgModelRow1_;
			}
			set
			{
				hv_OrgModelRow1_ = value;
			}
		}

		[XmlElement]
		public double hv_OrgModelColumn1
		{
			get
			{
				return hv_OrgModelColumn1_;
			}
			set
			{
				hv_OrgModelColumn1_ = value;
			}
		}

		[XmlElement]
		public double hv_OrgModelAngle1
		{
			get
			{
				return hv_OrgModelAngle1_;
			}
			set
			{
				hv_OrgModelAngle1_ = value;
			}
		}

		[XmlElement]
		public double hvCalibrationRow
		{
			get
			{
				return hvCalibrationRow_;
			}
			set
			{
				hvCalibrationRow_ = value;
			}
		}

		[XmlElement]
		public double hvCalibrationCol
		{
			get
			{
				return hvCalibrationCol_;
			}
			set
			{
				hvCalibrationCol_ = value;
			}
		}

		[XmlElement]
		public double hvCalibrationRadus
		{
			get
			{
				return hvCalibrationRadus_;
			}
			set
			{
				hvCalibrationRadus_ = value;
			}
		}

		[XmlElement]
		public double hvUpAreaMin
		{
			get
			{
				return hvUpAreaMin_;
			}
			set
			{
				hvUpAreaMin_ = value;
			}
		}

		[XmlElement]
		public double hvUpAreaMax
		{
			get
			{
				return hvUpAreaMax_;
			}
			set
			{
				hvUpAreaMax_ = value;
			}
		}

		[XmlElement]
		public double hvDwAreaMin
		{
			get
			{
				return hvDwAreaMin_;
			}
			set
			{
				hvDwAreaMin_ = value;
			}
		}

		[XmlElement]
		public double hvDwAreaMax
		{
			get
			{
				return hvDwAreaMax_;
			}
			set
			{
				hvDwAreaMax_ = value;
			}
		}

		[XmlElement]
		public double hvLAreaMin
		{
			get
			{
				return hvLAreaMin_;
			}
			set
			{
				hvLAreaMin_ = value;
			}
		}

		[XmlElement]
		public double hvLAreaMax
		{
			get
			{
				return hvLAreaMax_;
			}
			set
			{
				hvLAreaMax_ = value;
			}
		}

		[XmlElement]
		public double hvRAreaMin
		{
			get
			{
				return hvRAreaMin_;
			}
			set
			{
				hvRAreaMin_ = value;
			}
		}

		[XmlElement]
		public double hvRAreaMax
		{
			get
			{
				return hvRAreaMax_;
			}
			set
			{
				hvRAreaMax_ = value;
			}
		}

		[XmlElement]
		public double hvUpCameraResRow
		{
			get
			{
				return hvUpCameraResRow_;
			}
			set
			{
				hvUpCameraResRow_ = value;
			}
		}

		[XmlElement]
		public double hvUpCameraResCol
		{
			get
			{
				return hvUpCameraResCol_;
			}
			set
			{
				hvUpCameraResCol_ = value;
			}
		}

		[XmlElement]
		public double hvDwCameraResRow
		{
			get
			{
				return hvDwCameraResRow_;
			}
			set
			{
				hvDwCameraResRow_ = value;
			}
		}

		[XmlElement]
		public double hvDwCameraResCol
		{
			get
			{
				return hvDwCameraResCol_;
			}
			set
			{
				hvDwCameraResCol_ = value;
			}
		}

		[XmlElement]
		public double hvRotaCenRow1
		{
			get
			{
				return hvRotaCenRow1_;
			}
			set
			{
				hvRotaCenRow1_ = value;
			}
		}

		[XmlElement]
		public double hvRotaCenCol1
		{
			get
			{
				return hvRotaCenCol1_;
			}
			set
			{
				hvRotaCenCol1_ = value;
			}
		}

		[XmlElement]
		public double hvRotaCenRow2
		{
			get
			{
				return hvRotaCenRow2_;
			}
			set
			{
				hvRotaCenRow2_ = value;
			}
		}

		[XmlElement]
		public double hvRotaCenCol2
		{
			get
			{
				return hvRotaCenCol2_;
			}
			set
			{
				hvRotaCenCol2_ = value;
			}
		}

		[XmlElement]
		public double hvRotaCenRow3
		{
			get
			{
				return hvRotaCenRow3_;
			}
			set
			{
				hvRotaCenRow3_ = value;
			}
		}

		[XmlElement]
		public double hvRotaCenCol3
		{
			get
			{
				return hvRotaCenCol3_;
			}
			set
			{
				hvRotaCenCol3_ = value;
			}
		}

		[XmlElement]
		public double hvRotaCenRow4
		{
			get
			{
				return hvRotaCenRow4_;
			}
			set
			{
				hvRotaCenRow4_ = value;
			}
		}

		[XmlElement]
		public double hvRotaCenCol4
		{
			get
			{
				return hvRotaCenCol4_;
			}
			set
			{
				hvRotaCenCol4_ = value;
			}
		}

		[XmlElement]
		public double hvUDOffsetAgle
		{
			get
			{
				return hvUDOffsetAgle_;
			}
			set
			{
				hvUDOffsetAgle_ = value;
			}
		}

		[XmlElement]
		public int iOKPicSave
		{
			get
			{
				return iOKPicSave_;
			}
			set
			{
				iOKPicSave_ = value;
			}
		}

		[XmlElement]
		public int iNGPicSave
		{
			get
			{
				return iNGPicSave_;
			}
			set
			{
				iNGPicSave_ = value;
			}
		}

		[XmlElement]
		public int iniUpCameraTime
		{
			get
			{
				return iniUpCameraTime_;
			}
			set
			{
				iniUpCameraTime_ = value;
			}
		}

		[XmlElement]
		public int iniUpExposureTime
		{
			get
			{
				return iniUpExposureTime_;
			}
			set
			{
				iniUpExposureTime_ = value;
			}
		}

		[XmlElement]
		public double iniUpCameraGain
		{
			get
			{
				return iniUpCameraGain_;
			}
			set
			{
				iniUpCameraGain_ = value;
			}
		}

		[XmlElement]
		public int iniDelaySendTime
		{
			get
			{
				return iniDelaySendTime_;
			}
			set
			{
				iniDelaySendTime_ = value;
			}
		}

		[XmlElement]
		public int iniDownCameraTime
		{
			get
			{
				return iniDownCameraTime_;
			}
			set
			{
				iniDownCameraTime_ = value;
			}
		}

		[XmlElement]
		public int iniDownExposureTime
		{
			get
			{
				return iniDownExposureTime_;
			}
			set
			{
				iniDownExposureTime_ = value;
			}
		}

		[XmlElement]
		public int iniSaveNGDayCmbIndex
		{
			get
			{
				return iniSaveNGDayCmbIndex_;
			}
			set
			{
				iniSaveNGDayCmbIndex_ = value;
			}
		}

		[XmlElement]
		public int iniStartSaveDay
		{
			get
			{
				return iniStartSaveDay_;
			}
			set
			{
				iniStartSaveDay_ = value;
			}
		}

		[XmlElement]
		public int iniStartSaveMonth
		{
			get
			{
				return iniStartSaveMonth_;
			}
			set
			{
				iniStartSaveMonth_ = value;
			}
		}

		[XmlElement]
		public double iniDownRow
		{
			get
			{
				return iniDownRow_;
			}
			set
			{
				iniDownRow_ = value;
			}
		}

		[XmlElement]
		public double iniDownCol
		{
			get
			{
				return iniDownCol_;
			}
			set
			{
				iniDownCol_ = value;
			}
		}

		[XmlElement]
		public double iniDownPhi
		{
			get
			{
				return iniDownPhi_;
			}
			set
			{
				iniDownPhi_ = value;
			}
		}

		[XmlElement]
		public double iniDownLength11
		{
			get
			{
				return iniDownLength11_;
			}
			set
			{
				iniDownLength11_ = value;
			}
		}

		[XmlElement]
		public double iniDownLength21
		{
			get
			{
				return iniDownLength21_;
			}
			set
			{
				iniDownLength21_ = value;
			}
		}

		[XmlElement]
		public double iniLeftRow
		{
			get
			{
				return iniLeftRow_;
			}
			set
			{
				iniLeftRow_ = value;
			}
		}

		[XmlElement]
		public double iniLeftCol
		{
			get
			{
				return iniLeftCol_;
			}
			set
			{
				iniLeftCol_ = value;
			}
		}

		[XmlElement]
		public double iniLeftPhi
		{
			get
			{
				return iniLeftPhi_;
			}
			set
			{
				iniLeftPhi_ = value;
			}
		}

		[XmlElement]
		public double iniLeftLength11
		{
			get
			{
				return iniLeftLength11_;
			}
			set
			{
				iniLeftLength11_ = value;
			}
		}

		[XmlElement]
		public double iniLeftLength21
		{
			get
			{
				return iniLeftLength21_;
			}
			set
			{
				iniLeftLength21_ = value;
			}
		}

		[XmlElement]
		public string iniProjectNO
		{
			get
			{
				return iniProjectNO_;
			}
			set
			{
				iniProjectNO_ = value;
			}
		}

		[XmlElement]
		public double iniUpOffset
		{
			get
			{
				return iniUpOffset_;
			}
			set
			{
				iniUpOffset_ = value;
			}
		}

		[XmlElement]
		public double iniDownOffset
		{
			get
			{
				return iniDownOffset_;
			}
			set
			{
				iniDownOffset_ = value;
			}
		}

		[XmlElement]
		public double iniLeftOffset
		{
			get
			{
				return iniLeftOffset_;
			}
			set
			{
				iniLeftOffset_ = value;
			}
		}

		[XmlElement]
		public double iniRightOffset
		{
			get
			{
				return iniRightOffset_;
			}
			set
			{
				iniRightOffset_ = value;
			}
		}

		[XmlElement]
		public double iniAngleOffset
		{
			get
			{
				return iniAngleOffset_;
			}
			set
			{
				iniAngleOffset_ = value;
			}
		}

		[XmlElement]
		public double iniAreaOffset
		{
			get
			{
				return iniAreaOffset_;
			}
			set
			{
				iniAreaOffset_ = value;
			}
		}

		[XmlElement]
		public double iniMatchValue
		{
			get
			{
				return iniMatchValue_;
			}
			set
			{
				iniMatchValue_ = value;
			}
		}

		[XmlElement]
		public int iniThresholdValue
		{
			get
			{
				return iniThresholdValue_;
			}
			set
			{
				iniThresholdValue_ = value;
			}
		}

		[XmlElement]
		public double iniScale
		{
			get
			{
				return iniScale_;
			}
			set
			{
				iniScale_ = value;
			}
		}
	}
}
