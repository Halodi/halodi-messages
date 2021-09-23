using System.IO;
namespace halodi_msgs.msg
{

/**
* 
* Topic data type of the struct "RobotStatusAction" defined in "RobotStatusAction.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from RobotStatusAction.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit RobotStatusAction.idl instead.
*
*/
public class RobotStatusActionPubSubType : Halodi.CDR.TopicDataType<RobotStatusAction>
{
   public override string Name => "halodi_msgs::msg::dds_::RobotStatusAction_";


   
   public override void serialize(halodi_msgs.msg.RobotStatusAction data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, halodi_msgs.msg.RobotStatusAction data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(halodi_msgs.msg.RobotStatusAction data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(halodi_msgs.msg.RobotStatusAction data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 1 + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);



      return current_alignment - initial_alignment;
   }

   public static void write(halodi_msgs.msg.RobotStatusAction data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_9(data.action);

   }

   public static void read(halodi_msgs.msg.RobotStatusAction data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.action=cdr.read_type_9();
      	

   }


    public static void Copy(halodi_msgs.msg.RobotStatusAction src, halodi_msgs.msg.RobotStatusAction target)
    {
        target.Set(src);
    }


}


}