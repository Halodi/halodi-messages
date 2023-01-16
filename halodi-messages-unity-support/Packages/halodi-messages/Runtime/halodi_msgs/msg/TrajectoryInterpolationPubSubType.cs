using System.IO;
namespace halodi_msgs.msg
{

/**
* 
* Topic data type of the struct "TrajectoryInterpolation" defined in "TrajectoryInterpolation.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from TrajectoryInterpolation.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit TrajectoryInterpolation.idl instead.
*
*/
public class TrajectoryInterpolationPubSubType : Halodi.CDR.TopicDataType<TrajectoryInterpolation>
{
   public override string Name => "halodi_msgs::msg::dds_::TrajectoryInterpolation_";


   public static int getCdrSerializedSize(halodi_msgs.msg.TrajectoryInterpolation data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(halodi_msgs.msg.TrajectoryInterpolation data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 1 + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);



      return current_alignment - initial_alignment;
   }

   public static void write(halodi_msgs.msg.TrajectoryInterpolation data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_9(data.value);

   }

   public static void read(halodi_msgs.msg.TrajectoryInterpolation data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.value=cdr.read_type_9();
      	

   }


	public override void Serialize(halodi_msgs.msg.TrajectoryInterpolation data, Halodi.CDR.CDRSerializer cdr)
   	{
   		write(data, cdr);	
   	}

	public override void Deserialize(halodi_msgs.msg.TrajectoryInterpolation data, Halodi.CDR.CDRDeserializer cdr)
   	{
   		read(data, cdr);	
   	}
   	
   	public override int GetSize(halodi_msgs.msg.TrajectoryInterpolation data)
   	{
   		return getCdrSerializedSize(data);
   	}

    public static void Copy(halodi_msgs.msg.TrajectoryInterpolation src, halodi_msgs.msg.TrajectoryInterpolation target)
    {
        target.Set(src);
    }
    
    public override void CopyTo(halodi_msgs.msg.TrajectoryInterpolation src, halodi_msgs.msg.TrajectoryInterpolation target)
    {
    	Copy(src, target);
    }


}


}