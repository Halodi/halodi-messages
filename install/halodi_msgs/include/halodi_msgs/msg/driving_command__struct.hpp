// generated from rosidl_generator_cpp/resource/idl__struct.hpp.em
// with input from halodi_msgs:msg/DrivingCommand.idl
// generated code does not contain a copyright notice

#ifndef HALODI_MSGS__MSG__DRIVING_COMMAND__STRUCT_HPP_
#define HALODI_MSGS__MSG__DRIVING_COMMAND__STRUCT_HPP_

#include <rosidl_generator_cpp/bounded_vector.hpp>
#include <rosidl_generator_cpp/message_initialization.hpp>
#include <algorithm>
#include <array>
#include <memory>
#include <string>
#include <vector>


#ifndef _WIN32
# define DEPRECATED__halodi_msgs__msg__DrivingCommand __attribute__((deprecated))
#else
# define DEPRECATED__halodi_msgs__msg__DrivingCommand __declspec(deprecated)
#endif

namespace halodi_msgs
{

namespace msg
{

// message struct
template<class ContainerAllocator>
struct DrivingCommand_
{
  using Type = DrivingCommand_<ContainerAllocator>;

  explicit DrivingCommand_(rosidl_generator_cpp::MessageInitialization _init = rosidl_generator_cpp::MessageInitialization::ALL)
  {
    if (rosidl_generator_cpp::MessageInitialization::ALL == _init ||
      rosidl_generator_cpp::MessageInitialization::ZERO == _init)
    {
      this->filter_driving_command = false;
      this->linear_velocity = 0.0;
      this->angular_velocity = 0.0;
    }
  }

  explicit DrivingCommand_(const ContainerAllocator & _alloc, rosidl_generator_cpp::MessageInitialization _init = rosidl_generator_cpp::MessageInitialization::ALL)
  {
    (void)_alloc;
    if (rosidl_generator_cpp::MessageInitialization::ALL == _init ||
      rosidl_generator_cpp::MessageInitialization::ZERO == _init)
    {
      this->filter_driving_command = false;
      this->linear_velocity = 0.0;
      this->angular_velocity = 0.0;
    }
  }

  // field types and members
  using _filter_driving_command_type =
    bool;
  _filter_driving_command_type filter_driving_command;
  using _linear_velocity_type =
    double;
  _linear_velocity_type linear_velocity;
  using _angular_velocity_type =
    double;
  _angular_velocity_type angular_velocity;

  // setters for named parameter idiom
  Type & set__filter_driving_command(
    const bool & _arg)
  {
    this->filter_driving_command = _arg;
    return *this;
  }
  Type & set__linear_velocity(
    const double & _arg)
  {
    this->linear_velocity = _arg;
    return *this;
  }
  Type & set__angular_velocity(
    const double & _arg)
  {
    this->angular_velocity = _arg;
    return *this;
  }

  // constant declarations

  // pointer types
  using RawPtr =
    halodi_msgs::msg::DrivingCommand_<ContainerAllocator> *;
  using ConstRawPtr =
    const halodi_msgs::msg::DrivingCommand_<ContainerAllocator> *;
  using SharedPtr =
    std::shared_ptr<halodi_msgs::msg::DrivingCommand_<ContainerAllocator>>;
  using ConstSharedPtr =
    std::shared_ptr<halodi_msgs::msg::DrivingCommand_<ContainerAllocator> const>;

  template<typename Deleter = std::default_delete<
      halodi_msgs::msg::DrivingCommand_<ContainerAllocator>>>
  using UniquePtrWithDeleter =
    std::unique_ptr<halodi_msgs::msg::DrivingCommand_<ContainerAllocator>, Deleter>;

  using UniquePtr = UniquePtrWithDeleter<>;

  template<typename Deleter = std::default_delete<
      halodi_msgs::msg::DrivingCommand_<ContainerAllocator>>>
  using ConstUniquePtrWithDeleter =
    std::unique_ptr<halodi_msgs::msg::DrivingCommand_<ContainerAllocator> const, Deleter>;
  using ConstUniquePtr = ConstUniquePtrWithDeleter<>;

  using WeakPtr =
    std::weak_ptr<halodi_msgs::msg::DrivingCommand_<ContainerAllocator>>;
  using ConstWeakPtr =
    std::weak_ptr<halodi_msgs::msg::DrivingCommand_<ContainerAllocator> const>;

  // pointer types similar to ROS 1, use SharedPtr / ConstSharedPtr instead
  // NOTE: Can't use 'using' here because GNU C++ can't parse attributes properly
  typedef DEPRECATED__halodi_msgs__msg__DrivingCommand
    std::shared_ptr<halodi_msgs::msg::DrivingCommand_<ContainerAllocator>>
    Ptr;
  typedef DEPRECATED__halodi_msgs__msg__DrivingCommand
    std::shared_ptr<halodi_msgs::msg::DrivingCommand_<ContainerAllocator> const>
    ConstPtr;

  // comparison operators
  bool operator==(const DrivingCommand_ & other) const
  {
    if (this->filter_driving_command != other.filter_driving_command) {
      return false;
    }
    if (this->linear_velocity != other.linear_velocity) {
      return false;
    }
    if (this->angular_velocity != other.angular_velocity) {
      return false;
    }
    return true;
  }
  bool operator!=(const DrivingCommand_ & other) const
  {
    return !this->operator==(other);
  }
};  // struct DrivingCommand_

// alias to use template instance with default allocator
using DrivingCommand =
  halodi_msgs::msg::DrivingCommand_<std::allocator<void>>;

// constant definitions

}  // namespace msg

}  // namespace halodi_msgs

#endif  // HALODI_MSGS__MSG__DRIVING_COMMAND__STRUCT_HPP_
