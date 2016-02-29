# This file was generated by typhen-api

module TyphenApi::Model::Submarine::Battle
  class Movement
    include Virtus.model(:strict => true)

    attribute :actor_id, Integer, :required => true
    attribute :position, TyphenApi::Model::Submarine::Battle::Point, :required => true
    attribute :direction, Number, :required => true
    attribute :moved_at, Integer, :required => true
    attribute :accelerator, TyphenApi::Model::Submarine::Battle::Accelerator, :required => false
  end
end
