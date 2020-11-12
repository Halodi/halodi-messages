using System.IO;
namespace halodi_msgs.msg
{

/**
* 
* Topic data type of the struct "ImuName" defined in "ImuName.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from ImuName.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit ImuName.idl instead.
*
*/
public class ImuNamePubSubType : Halodi.CDR.TopicDataType<halodi_msgs.msg.ImuName>
{
   public override string Name => "halodi_msgs::msg::dds_::ImuName_";


   
   public override void serialize(halodi_msgs.msg.ImuName data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, halodi_msgs.msg.ImuName data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(halodi_msgs.msg.ImuName data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(halodi_msgs.msg.ImuName data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);



      return current_alignment - initial_alignment;
   }

   public static void write(halodi_msgs.msg.ImuName data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_2(data.imu_id);

   }

   public static void read(halodi_msgs.msg.ImuName data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.imu_id=cdr.read_type_2();
      	

   }


    public static void Copy(halodi_msgs.msg.ImuName src, halodi_msgs.msg.ImuName target)
    {
        target.Set(src);
    }


}


}