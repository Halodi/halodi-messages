using System.IO;
namespace halodi_msgs.msg
{

/**
* 
* Topic data type of the struct "JointName" defined in "JointName.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from JointName.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit JointName.idl instead.
*
*/
public class JointNamePubSubType : Halodi.CDR.TopicDataType<JointName>
{
   public override string Name => "halodi_msgs::msg::dds_::JointName_";


   
   public override void serialize(halodi_msgs.msg.JointName data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, halodi_msgs.msg.JointName data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(halodi_msgs.msg.JointName data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(halodi_msgs.msg.JointName data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);



      return current_alignment - initial_alignment;
   }

   public static void write(halodi_msgs.msg.JointName data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_2(data.joint_id);

   }

   public static void read(halodi_msgs.msg.JointName data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.joint_id=cdr.read_type_2();
      	

   }


    public static void Copy(halodi_msgs.msg.JointName src, halodi_msgs.msg.JointName target)
    {
        target.Set(src);
    }


}


}