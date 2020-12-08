// generated from rosidl_generator_cpp/resource/idl__struct.hpp.em
// with input from halodi_msgs:msg/PassivityData.idl
// generated code does not contain a copyright notice

#ifndef HALODI_MSGS__MSG__PASSIVITY_DATA__STRUCT_HPP_
#define HALODI_MSGS__MSG__PASSIVITY_DATA__STRUCT_HPP_

#include <rosidl_generator_cpp/bounded_vector.hpp>
#include <rosidl_generator_cpp/message_initialization.hpp>
#include <algorithm>
#include <array>
#include <memory>
#include <string>
#include <vector>


#ifndef _WIN32
# define DEPRECATED__halodi_msgs__msg__PassivityData __attribute__((deprecated))
#else
# define DEPRECATED__halodi_msgs__msg__PassivityData __declspec(deprecated)
#endif

namespace halodi_msgs
{

namespace msg
{

// message struct
template<class ContainerAllocator>
struct PassivityData_
{
  using Type = PassivityData_<ContainerAllocator>;

  explicit PassivityData_(rosidl_generator_cpp::MessageInitialization _init = rosidl_generator_cpp::MessageInitialization::ALL)
  {
    if (rosidl_generator_cpp::MessageInitialization::ALL == _init ||
      rosidl_generator_cpp::MessageInitialization::ZERO == _init)
    {
      this->energy_packet = 0.0;
      this->energy_tank_level = 0.0;
      this->virtual_mass = 0.0;
    }
  }

  explicit PassivityData_(const ContainerAllocator & _alloc, rosidl_generator_cpp::MessageInitialization _init = rosidl_generator_cpp::MessageInitialization::ALL)
  {
    (void)_alloc;
    if (rosidl_generator_cpp::MessageInitialization::ALL == _init ||
      rosidl_generator_cpp::MessageInitialization::ZERO == _init)
    {
      this->energy_packet = 0.0;
      this->energy_tank_level = 0.0;
      this->virtual_mass = 0.0;
    }
  }

  // field types and members
  using _energy_packet_type =
    double;
  _energy_packet_type energy_packet;
  using _energy_tank_level_type =
    double;
  _energy_tank_level_type energy_tank_level;
  using _virtual_mass_type =
    double;
  _virtual_mass_type virtual_mass;

  // setters for named parameter idiom
  Type & set__energy_packet(
    const double & _arg)
  {
    this->energy_packet = _arg;
    return *this;
  }
  Type & set__energy_tank_level(
    const double & _arg)
  {
    this->energy_tank_level = _arg;
    return *this;
  }
  Type & set__virtual_mass(
    const double & _arg)
  {
    this->virtual_mass = _arg;
    return *this;
  }

  // constant declarations

  // pointer types
  using RawPtr =
    halodi_msgs::msg::PassivityData_<ContainerAllocator> *;
  using ConstRawPtr =
    const halodi_msgs::msg::PassivityData_<ContainerAllocator> *;
  using SharedPtr =
    std::shared_ptr<halodi_msgs::msg::PassivityData_<ContainerAllocator>>;
  using ConstSharedPtr =
    std::shared_ptr<halodi_msgs::msg::PassivityData_<ContainerAllocator> const>;

  template<typename Deleter = std::default_delete<
      halodi_msgs::msg::PassivityData_<ContainerAllocator>>>
  using UniquePtrWithDeleter =
    std::unique_ptr<halodi_msgs::msg::PassivityData_<ContainerAllocator>, Deleter>;

  using UniquePtr = UniquePtrWithDeleter<>;

  template<typename Deleter = std::default_delete<
      halodi_msgs::msg::PassivityData_<ContainerAllocator>>>
  using ConstUniquePtrWithDeleter =
    std::unique_ptr<halodi_msgs::msg::PassivityData_<ContainerAllocator> const, Deleter>;
  using ConstUniquePtr = ConstUniquePtrWithDeleter<>;

  using WeakPtr =
    std::weak_ptr<halodi_msgs::msg::PassivityData_<ContainerAllocator>>;
  using ConstWeakPtr =
    std::weak_ptr<halodi_msgs::msg::PassivityData_<ContainerAllocator> const>;

  // pointer types similar to ROS 1, use SharedPtr / ConstSharedPtr instead
  // NOTE: Can't use 'using' here because GNU C++ can't parse attributes properly
  typedef DEPRECATED__halodi_msgs__msg__PassivityData
    std::shared_ptr<halodi_msgs::msg::PassivityData_<ContainerAllocator>>
    Ptr;
  typedef DEPRECATED__halodi_msgs__msg__PassivityData
    std::shared_ptr<halodi_msgs::msg::PassivityData_<ContainerAllocator> const>
    ConstPtr;

  // comparison operators
  bool operator==(const PassivityData_ & other) const
  {
    if (this->energy_packet != other.energy_packet) {
      return false;
    }
    if (this->energy_tank_level != other.energy_tank_level) {
      return false;
    }
    if (this->virtual_mass != other.virtual_mass) {
      return false;
    }
    return true;
  }
  bool operator!=(const PassivityData_ & other) const
  {
    return !this->operator==(other);
  }
};  // struct PassivityData_

// alias to use template instance with default allocator
using PassivityData =
  halodi_msgs::msg::PassivityData_<std::allocator<void>>;

// constant definitions

}  // namespace msg

}  // namespace halodi_msgs

#endif  // HALODI_MSGS__MSG__PASSIVITY_DATA__STRUCT_HPP_
