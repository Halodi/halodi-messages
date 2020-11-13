using System.IO;
namespace rcl_interfaces.msg
{

/**
* 
* Topic data type of the struct "Log" defined in "Log.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from Log.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit Log.idl instead.
*
*/
public class LogPubSubType : Halodi.CDR.TopicDataType<Log>
{
   public override string Name => "rcl_interfaces::msg::dds_::Log_";


   
   public override void serialize(rcl_interfaces.msg.Log data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, rcl_interfaces.msg.Log data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(rcl_interfaces.msg.Log data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(rcl_interfaces.msg.Log data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += builtin_interfaces.msg.TimePubSubType.getCdrSerializedSize(data.stamp, current_alignment);

      current_alignment += 1 + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.name.Length + 1;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.msg.Length + 1;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.file.Length + 1;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.function.Length + 1;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);



      return current_alignment - initial_alignment;
   }

   public static void write(rcl_interfaces.msg.Log data, Halodi.CDR.CDRSerializer cdr)
   {
      builtin_interfaces.msg.TimePubSubType.write(data.stamp, cdr);

      cdr.write_type_9(data.level);

      cdr.write_type_d(data.name);

      cdr.write_type_d(data.msg);

      cdr.write_type_d(data.file);

      cdr.write_type_d(data.function);

      cdr.write_type_4(data.line);

   }

   public static void read(rcl_interfaces.msg.Log data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.stamp = builtin_interfaces.msg.TimePubSubType.Create();
      builtin_interfaces.msg.TimePubSubType.read(data.stamp, cdr);
      	
      data.level=cdr.read_type_9();
      	
      data.name = cdr.read_type_d();	
      data.msg = cdr.read_type_d();	
      data.file = cdr.read_type_d();	
      data.function = cdr.read_type_d();	
      data.line=cdr.read_type_4();
      	

   }


    public static void Copy(rcl_interfaces.msg.Log src, rcl_interfaces.msg.Log target)
    {
        target.Set(src);
    }


}


}