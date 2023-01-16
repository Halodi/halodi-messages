using System.IO;
namespace halodi_msgs.msg
{

/**
* 
* Topic data type of the struct "JointCalibration" defined in "JointCalibration.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from JointCalibration.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit JointCalibration.idl instead.
*
*/
public class JointCalibrationPubSubType : Halodi.CDR.TopicDataType<JointCalibration>
{
   public override string Name => "halodi_msgs::msg::dds_::JointCalibrationInfo_";


   public static int getCdrSerializedSize(halodi_msgs.msg.JointCalibration data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(halodi_msgs.msg.JointCalibration data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.joint_name.Length + 1;

      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);



      return current_alignment - initial_alignment;
   }

   public static void write(halodi_msgs.msg.JointCalibration data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_d(data.joint_name);

      cdr.write_type_6(data.measurement_multiplier);

      cdr.write_type_6(data.measurement_bias);

   }

   public static void read(halodi_msgs.msg.JointCalibration data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.joint_name = cdr.read_type_d();	
      data.measurement_multiplier=cdr.read_type_6();
      	
      data.measurement_bias=cdr.read_type_6();
      	

   }


	public override void Serialize(halodi_msgs.msg.JointCalibration data, Halodi.CDR.CDRSerializer cdr)
   	{
   		write(data, cdr);	
   	}

	public override void Deserialize(halodi_msgs.msg.JointCalibration data, Halodi.CDR.CDRDeserializer cdr)
   	{
   		read(data, cdr);	
   	}
   	
   	public override int GetSize(halodi_msgs.msg.JointCalibration data)
   	{
   		return getCdrSerializedSize(data);
   	}

    public static void Copy(halodi_msgs.msg.JointCalibration src, halodi_msgs.msg.JointCalibration target)
    {
        target.Set(src);
    }
    
    public override void CopyTo(halodi_msgs.msg.JointCalibration src, halodi_msgs.msg.JointCalibration target)
    {
    	Copy(src, target);
    }


}


}