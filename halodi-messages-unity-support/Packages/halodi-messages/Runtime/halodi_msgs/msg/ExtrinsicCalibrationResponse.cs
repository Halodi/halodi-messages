using System.Text;
namespace halodi_msgs.msg
{


/**
          * Status of the battery
          *
          */
[System.Serializable]
public class ExtrinsicCalibrationResponse : Halodi.CDR.DataType<ExtrinsicCalibrationResponse>
{

	public Halodi.CDR.TopicDataType<ExtrinsicCalibrationResponse> Type => new ExtrinsicCalibrationResponsePubSubType();
	
   public const byte ACCEPTED = (byte) 0;
   public const byte CONTROLLER_RESTART_REQUIRED = (byte) 1;
   /**
                * Acknowledge status for extrinsic calibraiton
                *
                */
   public byte status;


   public void Set(ExtrinsicCalibrationResponse other)
   {
      status = other.status;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("ExtrinsicCalibrationResponse {");
      builder.Append("status=");
      builder.Append(this.status);
      builder.Append("}");
      return builder.ToString();
   }
}


}