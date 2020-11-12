using System.IO;
namespace sensor_msgs.msg
{

/**
* 
* Topic data type of the struct "LaserEcho" defined in "LaserEcho.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from LaserEcho.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit LaserEcho.idl instead.
*
*/
public class LaserEchoPubSubType : Halodi.CDR.TopicDataType<sensor_msgs.msg.LaserEcho>
{
   public override string Name => "sensor_msgs::msg::dds_::LaserEcho_";


   
   public override void serialize(sensor_msgs.msg.LaserEcho data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, sensor_msgs.msg.LaserEcho data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(sensor_msgs.msg.LaserEcho data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(sensor_msgs.msg.LaserEcho data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      current_alignment += (data.echoes.Count * 4) + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      return current_alignment - initial_alignment;
   }

   public static void write(sensor_msgs.msg.LaserEcho data, Halodi.CDR.CDRSerializer cdr)
   {
      	if(data.echoes == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int echoes_length = data.echoes.Count;
            cdr.write_type_2(echoes_length);
            for (int i0 = 0; i0 < echoes_length; i0++)
            {
      			cdr.write_type_5(data.echoes[i0]);
            }
        }   }

   public static void read(sensor_msgs.msg.LaserEcho data, Halodi.CDR.CDRDeserializer cdr)
   {

      int echoes_length = cdr.read_type_2();
      data.echoes = new System.Collections.Generic.List<float>(echoes_length);
      for(int i = 0; i < echoes_length; i++)
      {
      	data.echoes.Add(cdr.read_type_5());
      	
      	
      }

      	

   }


    public static void Copy(sensor_msgs.msg.LaserEcho src, sensor_msgs.msg.LaserEcho target)
    {
        target.Set(src);
    }


}


}